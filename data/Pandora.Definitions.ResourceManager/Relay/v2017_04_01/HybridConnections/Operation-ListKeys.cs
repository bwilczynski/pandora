using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Relay.v2017_04_01.HybridConnections
{
    internal class ListKeysOperation : Operations.PostOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes()
        {
            return new List<HttpStatusCode>
            {
                HttpStatusCode.OK,
            };
        }

        public override Type? RequestObject()
        {
            return null;
        }

        public override ResourceID? ResourceId()
        {
            return new AuthorizationRuleId();
        }

        public override Type? ResponseObject()
        {
            return typeof(AccessKeysModel);
        }

        public override string? UriSuffix()
        {
            return "/listKeys";
        }


    }
}