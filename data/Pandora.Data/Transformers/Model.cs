using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using Pandora.Data.Models;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;

namespace Pandora.Data.Transformers
{
    public static class Model
    {
        public static List<ModelDefinition> Map(object input)
        {
            if (input.GetType().IsAGenericList())
            {
                // TODO: implement me
                throw new NotSupportedException("create a wrapper type");
            }
            
            return MapObject(input.GetType()).Distinct(new ModelComparer()).OrderBy(m => m.Name).ToList();
        }

        private static IEnumerable<ModelDefinition> MapObject(Type input)
        {
            if (input.IsEnum)
            {
                return new List<ModelDefinition>();
            }

            var models = new List<ModelDefinition>();
            var properties = new List<PropertyDefinition>();

            var props = input.GetProperties();
            foreach (var property in props)
            {
                if (property.PropertyType.IsGenericType)
                {
                    if (property.PropertyType.GetGenericTypeDefinition() != typeof(List<>))
                    {
                        throw new NotSupportedException(string.Format($"{input.FullName} - {property.Name}: Generic types have to be lists"));
                    }

                    var innerType = property.PropertyType.GetGenericArguments()[0];
                    var mappedInner = MapObject(innerType);
                    models.AddRange(mappedInner);
                }
                else if (property.PropertyType.IsClass && !property.PropertyType.IsEnum &&
                         !Helpers.IsNativeType(property.PropertyType) &&
                         !Helpers.IsPandoraCustomType(property.PropertyType))
                {
                    models.AddRange(MapObject(property.PropertyType));
                }

                var mappedProperty = Property.Map(property);
                properties.Add(mappedProperty);
            }

            var model = new ModelDefinition
            {
                Name = input.Name,
                Properties = properties.OrderBy(p => p.Name).ToList(),
            };

            // this is an abstract class, meaning it's a Discriminated Type
            if (input.IsAbstract)
            {
                // 1: sanity checking: ensure one, and only one, of the fields has the DiscriminatesUsing field
                var propsWithTypeHints = input.GetProperties().Where(p => p.HasAttribute<ProvidesTypeHintAttribute>()).ToList();
                if (propsWithTypeHints.Count != 1)
                {
                    throw new NotSupportedException($"Exactly one attribute within {input.FullName} needs to contain the [ProvidesTypeHint] Attribute");
                }

                // 2: find all of the implementations for this type
                var allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes());
                var implementations = allTypes.Where(t => t.IsAssignableTo(input) && !t.IsAbstract && !t.IsInterface).ToList();
                foreach (var implementation in implementations)
                {
                    var mappedImplementations = MapObject(implementation);
                    foreach (var mappedImpl in mappedImplementations)
                    {
                        // ensure the nested model contains the name of the parent type so this can be
                        // easily mapped across later
                        mappedImpl.ParentTypeName = input.Name;
                        models.Add(mappedImpl);
                    }
                }

                // 3: map the property containing the type hint across
                var propWithTypeHint = propsWithTypeHints.First();
                model.TypeHintIn = propWithTypeHint.Name;
            }

            if (input.HasAttribute<ValueForTypeAttribute>())
            {
                if (input.IsInterface)
                {
                    throw new NotSupportedException($"Interface {input.FullName} may not have a [ValueForType] attribute");
                }

                var attr = input.GetCustomAttribute<ValueForTypeAttribute>();
                model.TypeHintValue = attr.Value;
                
                var fieldContainingTypeHint = input.GetProperties().Where(p => p.HasAttribute<ProvidesTypeHintAttribute>()).ToList();
                if (fieldContainingTypeHint.Count != 1)
                {
                    throw new NotSupportedException($"Exactly one attribute within {input.FullName} needs to contain the [ProvidesTypeHint] Attribute");
                }
                var propWithTypeHint = fieldContainingTypeHint.First();
                model.TypeHintIn = propWithTypeHint.Name;
            }
            
            models.Add(model);
            return models;
        }
    }
}