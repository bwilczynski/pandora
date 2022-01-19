using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2021_09_15_preview
{
    public partial class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2021-09-15-preview";
        public bool Preview => true;

        public IEnumerable<ApiDefinition> Apis => new List<ApiDefinition>
        {
            new Capabilities.Definition(),
            new CapabilityTypes.Definition(),
            new Experiments.Definition(),
            new TargetTypes.Definition(),
            new Targets.Definition(),
        };
    }
}