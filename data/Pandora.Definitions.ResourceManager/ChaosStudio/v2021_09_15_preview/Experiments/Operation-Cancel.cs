using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2021_09_15_preview.Experiments
{
    internal class CancelOperation : Operations.PostOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
        };

        public override bool LongRunning() => true;

        public override Type? RequestObject() => null;

        public override ResourceID? ResourceId() => new ExperimentId();

        public override Type? ResponseObject() => typeof(ExperimentCancelOperationResultModel);

        public override string? UriSuffix() => "/cancel";


    }
}