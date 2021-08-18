using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01
{
    public partial class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2020-10-01";
        public bool Preview => false;

        public IEnumerable<ApiDefinition> Apis => new List<ApiDefinition>
        {
            new AttestationProviders.Definition(),
            new PrivateEndpointConnections.Definition(),
        };
    }
}