using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_09_10.ReplicationProtectedItems;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DisableProtectionReasonConstant
{
    [Description("MigrationComplete")]
    MigrationComplete,

    [Description("NotSpecified")]
    NotSpecified,
}
