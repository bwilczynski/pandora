using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.LiveEvents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StretchModeConstant
{
    [Description("AutoFit")]
    AutoFit,

    [Description("AutoSize")]
    AutoSize,

    [Description("None")]
    None,
}
