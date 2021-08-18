using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.SignalR.v2020_05_01.SignalR
{
    internal class RegenerateKeyOperation : Operations.PostOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes()
        {
            return new List<HttpStatusCode>
            {
                HttpStatusCode.Created,
            };
        }

        public override bool LongRunning()
        {
            return true;
        }

        public override Type? RequestObject()
        {
            return typeof(RegenerateKeyParametersModel);
        }

        public override ResourceID? ResourceId()
        {
            return new SignalRId();
        }

        public override Type? ResponseObject()
        {
            return typeof(SignalRKeysModel);
        }

        public override string? UriSuffix()
        {
            return "/regenerateKey";
        }


    }
}