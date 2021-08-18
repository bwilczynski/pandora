using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_07_01.Account
{
    internal class AddRootCollectionAdminOperation : Operations.PostOperation
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
            return typeof(CollectionAdminUpdateModel);
        }

        public override ResourceID? ResourceId()
        {
            return new AccountId();
        }

        public override string? UriSuffix()
        {
            return "/addRootCollectionAdmin";
        }


    }
}