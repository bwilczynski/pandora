using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2021_04_30.PrivateEndpointConnections
{

    internal class PrivateEndpointConnectionModel
    {
        [JsonPropertyName("etag")]
        public string? Etag { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("location")]
        public CustomTypes.Location? Location { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("properties")]
        public PrivateEndpointConnectionPropertiesModel? Properties { get; set; }

        [JsonPropertyName("systemData")]
        public SystemDataModel? SystemData { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}