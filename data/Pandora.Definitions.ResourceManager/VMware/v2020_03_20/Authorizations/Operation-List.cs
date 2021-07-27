using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.Authorizations
{
    internal class List : ListOperation
    {
        public override string? FieldContainingPaginationDetails()
        {
            return "nextLink";
        }

        public override ResourceID? ResourceId()
        {
            return new PrivateCloudId();
        }

        public override object NestedItemType()
        {
            return new ExpressRouteAuthorization();
        }

        public override string? UriSuffix()
        {
            return "/authorizations";
        }


    }
}