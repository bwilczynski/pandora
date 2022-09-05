using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Compute.Terraform;

public class VirtualMachineResourceSubResourceSchema
{

    [HclName("id")]
    [Optional]
    public string Id { get; set; }

}
