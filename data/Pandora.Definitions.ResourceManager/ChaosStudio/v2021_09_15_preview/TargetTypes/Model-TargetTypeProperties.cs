using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2021_09_15_preview.TargetTypes
{

    internal class TargetTypePropertiesModel
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("propertiesSchema")]
        public string? PropertiesSchema { get; set; }

        [JsonPropertyName("resourceTypes")]
        public List<string>? ResourceTypes { get; set; }
    }
}