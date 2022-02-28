using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.QueueServiceProperties;


internal class CorsRuleModel
{
    [JsonPropertyName("allowedHeaders")]
    [Required]
    public List<string> AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    [Required]
    public List<AllowedMethodsConstant> AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    [Required]
    public List<string> AllowedOrigins { get; set; }

    [JsonPropertyName("exposedHeaders")]
    [Required]
    public List<string> ExposedHeaders { get; set; }

    [JsonPropertyName("maxAgeInSeconds")]
    [Required]
    public int MaxAgeInSeconds { get; set; }
}