using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.AttestationProviders
{

    internal class AttestationServiceCreationParamsModel
    {
        [JsonPropertyName("location")]
        [Required]
        public CustomTypes.Location Location { get; set; }

        [JsonPropertyName("properties")]
        [Required]
        public AttestationServiceCreationSpecificParamsModel Properties { get; set; }

        [JsonPropertyName("tags")]
        public CustomTypes.Tags? Tags { get; set; }
    }
}