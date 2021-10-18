using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.DataBricks.v2021_04_01_preview.GET
{
    internal class PrivateLinkResourcesGetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new PrivateLinkResourceId();

        public override Type? ResponseObject() => typeof(GroupIdInformationModel);


    }
}