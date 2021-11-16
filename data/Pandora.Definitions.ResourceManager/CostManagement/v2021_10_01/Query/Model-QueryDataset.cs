using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Query
{

    internal class QueryDatasetModel
    {
        [JsonPropertyName("aggregation")]
        public Dictionary<string, QueryAggregationModel>? Aggregation { get; set; }

        [JsonPropertyName("configuration")]
        public QueryDatasetConfigurationModel? Configuration { get; set; }

        [JsonPropertyName("filter")]
        public QueryFilterModel? Filter { get; set; }

        [JsonPropertyName("granularity")]
        public GranularityTypeConstant? Granularity { get; set; }

        [MaxItems(2)]
        [JsonPropertyName("grouping")]
        public List<QueryGroupingModel>? Grouping { get; set; }
    }
}