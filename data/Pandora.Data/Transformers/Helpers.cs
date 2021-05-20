using System;
using System.Collections.Generic;
using System.Reflection;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Data.Transformers
{
    internal static class Helpers
    {
        public static bool IsNativeType(Type input)
        {
            var nativeTypes = new List<Type>
            {
                typeof(bool),
                typeof(byte),
                typeof(int),
                typeof(object),
                typeof(string),
            };
            return nativeTypes.Contains(input);
        }

        public static bool IsPandoraCustomType(Type input)
        {
            var customTypes = new List<Type>
            {
                typeof(Location),
                typeof(Tags),
                // TODO: identity since these use dictionary[nested]
            };
            return customTypes.Contains(input);
        }

        internal static bool HasAttribute<T>(this MemberInfo info) where T : Attribute
        {
            return info.GetCustomAttribute<T>() != null;
        }

        internal static bool IsAGenericList(this Type input)
        {
            return input.IsGenericType && input.GetGenericTypeDefinition() == typeof(List<>);
        }

        internal static Type GenericListElement(this Type input)
        {
            if (!input.IsAGenericList())
            {
                throw new NotSupportedException($"unsupported list type {input.Name}");
            }

            return input.GetGenericArguments()[0];
        }
    }
}