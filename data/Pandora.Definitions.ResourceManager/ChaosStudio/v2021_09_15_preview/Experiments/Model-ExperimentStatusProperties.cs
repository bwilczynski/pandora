using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2021_09_15_preview.Experiments
{

    internal class ExperimentStatusPropertiesModel
    {
        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("createdDateUtc")]
        public DateTime? CreatedDateUtc { get; set; }

        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("endDateUtc")]
        public DateTime? EndDateUtc { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}