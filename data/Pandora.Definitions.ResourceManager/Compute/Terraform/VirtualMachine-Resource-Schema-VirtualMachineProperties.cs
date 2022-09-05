using System.Collections.Generic;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CommonSchema;

namespace Pandora.Definitions.ResourceManager.Compute.Terraform;

public class VirtualMachineResourceVirtualMachinePropertiesSchema
{

    [HclName("additional_capabilities")]
    [Optional]
    public List<VirtualMachineResourceAdditionalCapabilitiesSchema> AdditionalCapabilities { get; set; }


    [HclName("application_profile")]
    [Optional]
    public List<VirtualMachineResourceApplicationProfileSchema> ApplicationProfile { get; set; }


    [HclName("availability_set_id")]
    [Optional]
    public List<VirtualMachineResourceSubResourceSchema> AvailabilitySetId { get; set; }


    [HclName("billing_profile")]
    [Optional]
    public List<VirtualMachineResourceBillingProfileSchema> BillingProfile { get; set; }


    [HclName("capacity_reservation")]
    [Optional]
    public List<VirtualMachineResourceCapacityReservationProfileSchema> CapacityReservation { get; set; }


    [HclName("diagnostics_profile")]
    [Optional]
    public List<VirtualMachineResourceDiagnosticsProfileSchema> DiagnosticsProfile { get; set; }


    [HclName("eviction_policy")]
    [Optional]
    public string EvictionPolicy { get; set; }


    [HclName("extensions_time_budget")]
    [Optional]
    public string ExtensionsTimeBudget { get; set; }


    [HclName("hardware_profile")]
    [Optional]
    public List<VirtualMachineResourceHardwareProfileSchema> HardwareProfile { get; set; }


    [HclName("host_group_id")]
    [Optional]
    public List<VirtualMachineResourceSubResourceSchema> HostGroupId { get; set; }


    [HclName("host_id")]
    [Optional]
    public List<VirtualMachineResourceSubResourceSchema> HostId { get; set; }


    [HclName("instance_view")]
    [Optional]
    public List<VirtualMachineResourceVirtualMachineInstanceViewSchema> InstanceView { get; set; }


    [HclName("license_type")]
    [Optional]
    public string LicenseType { get; set; }


    [HclName("network_profile")]
    [Optional]
    public List<VirtualMachineResourceNetworkProfileSchema> NetworkProfile { get; set; }


    [HclName("os_profile")]
    [Optional]
    public List<VirtualMachineResourceOSProfileSchema> OsProfile { get; set; }


    [HclName("platform_fault_domain")]
    [Optional]
    public int PlatformFaultDomain { get; set; }


    [HclName("priority")]
    [Optional]
    public string Priority { get; set; }


    [HclName("provisioning_state")]
    [Optional]
    public string ProvisioningState { get; set; }


    [HclName("proximity_placement_group_id")]
    [Optional]
    public List<VirtualMachineResourceSubResourceSchema> ProximityPlacementGroupId { get; set; }


    [HclName("scheduled_events_profile")]
    [Optional]
    public List<VirtualMachineResourceScheduledEventsProfileSchema> ScheduledEventsProfile { get; set; }


    [HclName("security_profile")]
    [Optional]
    public List<VirtualMachineResourceSecurityProfileSchema> SecurityProfile { get; set; }


    [HclName("storage_profile")]
    [Optional]
    public List<VirtualMachineResourceStorageProfileSchema> StorageProfile { get; set; }


    [HclName("time_created")]
    [Optional]
    public System.DateTime TimeCreated { get; set; }


    [HclName("user_data")]
    [Optional]
    public string UserData { get; set; }


    [HclName("virtual_machine_scale_set_id")]
    [Optional]
    public List<VirtualMachineResourceSubResourceSchema> VirtualMachineScaleSetId { get; set; }


    [HclName("vm_id")]
    [Optional]
    public string VmId { get; set; }

}
