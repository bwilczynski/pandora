using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.AnalysisServices.v2017_08_01.Servers
{
    internal class ListOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId()
        {
            return new SubscriptionId();
        }

        public override Type? ResponseObject()
        {
            return typeof(AnalysisServicesServersModel);
        }

        public override string? UriSuffix()
        {
            return "/providers/Microsoft.AnalysisServices/servers";
        }


    }
}