using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.FrontDoors
{
    internal class FrontendEndpointsDisableHttpsOperation : Operations.PostOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.OK,
        };

        public override bool LongRunning() => true;

        public override Type? RequestObject() => null;

        public override ResourceID? ResourceId() => new FrontendEndpointId();

        public override string? UriSuffix() => "/disableHttps";


    }
}