using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.PrivateClouds
{
    internal class ListInSubscriptionOperation : Operations.ListOperation
    {
        public override string? FieldContainingPaginationDetails()
        {
            return "nextLink";
        }

        public override ResourceID? ResourceId()
        {
            return new SubscriptionId();
        }

        public override Type NestedItemType()
        {
            return typeof(PrivateCloudModel);
        }

        public override string? UriSuffix()
        {
            return "/providers/Microsoft.AVS/privateClouds";
        }


    }
}