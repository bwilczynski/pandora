using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.LabServices.v2021_10_01_preview.Image
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "1b64fac98b004c439dfffff4cbe93e413ff86709" 

        public string ApiVersion => "2021-10-01-preview";
        public string Name => "Image";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CreateOrUpdateOperation(),
            new GetOperation(),
            new ListByLabPlanOperation(),
            new UpdateOperation(),
        };
    }
}