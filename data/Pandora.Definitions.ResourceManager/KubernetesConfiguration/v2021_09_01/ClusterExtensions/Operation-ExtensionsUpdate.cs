using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2021_09_01.ClusterExtensions;

internal class ExtensionsUpdateOperation : Operations.PatchOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(PatchExtensionModel);

    public override ResourceID? ResourceId() => new ExtensionId();

    public override Type? ResponseObject() => typeof(ExtensionModel);


}