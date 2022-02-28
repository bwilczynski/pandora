using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.ManagementPolicies;


internal class ManagementPolicyVersionModel
{
    [JsonPropertyName("delete")]
    public DateAfterCreationModel? Delete { get; set; }

    [JsonPropertyName("tierToArchive")]
    public DateAfterCreationModel? TierToArchive { get; set; }

    [JsonPropertyName("tierToCool")]
    public DateAfterCreationModel? TierToCool { get; set; }
}