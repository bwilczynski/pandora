using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Bot.v2021_03_01.Channel;

[ValueForType("AlexaChannel")]
internal class AlexaChannelModel : ChannelModel
{
    [JsonPropertyName("properties")]
    public AlexaChannelPropertiesModel? Properties { get; set; }
}