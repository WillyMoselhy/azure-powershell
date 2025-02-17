// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Deployment along with OS Configuration.</summary>
    public partial class DeploymentWithOSConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfiguration __sapConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SapConfiguration();

        /// <summary>Backing field for <see cref="AppLocation" /> property.</summary>
        private string _appLocation;

        /// <summary>The geo-location where the SAP system is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string AppLocation { get => this._appLocation; set => this._appLocation = value; }

        /// <summary>The configuration Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapConfigurationType ConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfigurationInternal)__sapConfiguration).ConfigurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfigurationInternal)__sapConfiguration).ConfigurationType = value ; }

        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string DeployerVMPackageStorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageStorageAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageStorageAccountId = value ?? null; }

        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string DeployerVMPackageUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackageUrl = value ?? null; }

        /// <summary>Backing field for <see cref="InfrastructureConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfiguration _infrastructureConfiguration;

        /// <summary>The infrastructure configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfiguration InfrastructureConfiguration { get => (this._infrastructureConfiguration = this._infrastructureConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.InfrastructureConfiguration()); set => this._infrastructureConfiguration = value; }

        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string InfrastructureConfigurationAppResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfigurationInternal)InfrastructureConfiguration).AppResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfigurationInternal)InfrastructureConfiguration).AppResourceGroup = value ?? null; }

        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType? InfrastructureConfigurationDeploymentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfigurationInternal)InfrastructureConfiguration).DeploymentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfigurationInternal)InfrastructureConfiguration).DeploymentType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType)""); }

        /// <summary>Internal Acessors for InfrastructureConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfiguration Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfigurationInternal.InfrastructureConfiguration { get => (this._infrastructureConfiguration = this._infrastructureConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.InfrastructureConfiguration()); set { {_infrastructureConfiguration = value;} } }

        /// <summary>Internal Acessors for OSSapConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfiguration Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfigurationInternal.OSSapConfiguration { get => (this._oSSapConfiguration = this._oSSapConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.OSSapConfiguration()); set { {_oSSapConfiguration = value;} } }

        /// <summary>Internal Acessors for OSSapConfigurationDeployerVmpackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeployerVMPackages Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfigurationInternal.OSSapConfigurationDeployerVmpackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).DeployerVMPackage = value; }

        /// <summary>Internal Acessors for SoftwareConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfiguration Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeploymentWithOSConfigurationInternal.SoftwareConfiguration { get => (this._softwareConfiguration = this._softwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SoftwareConfiguration()); set { {_softwareConfiguration = value;} } }

        /// <summary>Backing field for <see cref="OSSapConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfiguration _oSSapConfiguration;

        /// <summary>The OS and SAP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfiguration OSSapConfiguration { get => (this._oSSapConfiguration = this._oSSapConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.OSSapConfiguration()); set => this._oSSapConfiguration = value; }

        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public string OSSapConfigurationSapFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).SapFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfigurationInternal)OSSapConfiguration).SapFqdn = value ?? null; }

        /// <summary>Backing field for <see cref="SoftwareConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfiguration _softwareConfiguration;

        /// <summary>The software configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfiguration SoftwareConfiguration { get => (this._softwareConfiguration = this._softwareConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.SoftwareConfiguration()); set => this._softwareConfiguration = value; }

        /// <summary>The SAP software installation Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapSoftwareInstallationType? SoftwareConfigurationSoftwareInstallationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfigurationInternal)SoftwareConfiguration).SoftwareInstallationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfigurationInternal)SoftwareConfiguration).SoftwareInstallationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapSoftwareInstallationType)""); }

        /// <summary>Creates an new <see cref="DeploymentWithOSConfiguration" /> instance.</summary>
        public DeploymentWithOSConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__sapConfiguration), __sapConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__sapConfiguration), __sapConfiguration);
        }
    }
    /// Deployment along with OS Configuration.
    public partial interface IDeploymentWithOSConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfiguration
    {
        /// <summary>The geo-location where the SAP system is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The geo-location where the SAP system is to be created.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string AppLocation { get; set; }
        /// <summary>The deployer VM packages storage account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The deployer VM packages storage account id",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to the deployer VM packages file.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application resource group where SAP system resources will be deployed.",
        SerializedName = @"appResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string InfrastructureConfigurationAppResourceGroup { get; set; }
        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of SAP deployment, single server or Three tier.",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType? InfrastructureConfigurationDeploymentType { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The FQDN to set for the SAP system",
        SerializedName = @"sapFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string OSSapConfigurationSapFqdn { get; set; }
        /// <summary>The SAP software installation Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SAP software installation Type.",
        SerializedName = @"softwareInstallationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapSoftwareInstallationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapSoftwareInstallationType? SoftwareConfigurationSoftwareInstallationType { get; set; }

    }
    /// Deployment along with OS Configuration.
    internal partial interface IDeploymentWithOSConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapConfigurationInternal
    {
        /// <summary>The geo-location where the SAP system is to be created.</summary>
        string AppLocation { get; set; }
        /// <summary>The deployer VM packages storage account id</summary>
        string DeployerVMPackageStorageAccountId { get; set; }
        /// <summary>The URL to the deployer VM packages file.</summary>
        string DeployerVMPackageUrl { get; set; }
        /// <summary>The infrastructure configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IInfrastructureConfiguration InfrastructureConfiguration { get; set; }
        /// <summary>The application resource group where SAP system resources will be deployed.</summary>
        string InfrastructureConfigurationAppResourceGroup { get; set; }
        /// <summary>The type of SAP deployment, single server or Three tier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType? InfrastructureConfigurationDeploymentType { get; set; }
        /// <summary>The OS and SAP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IOSSapConfiguration OSSapConfiguration { get; set; }
        /// <summary>The url and storage account ID where deployer VM packages are uploaded</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDeployerVMPackages OSSapConfigurationDeployerVmpackage { get; set; }
        /// <summary>The FQDN to set for the SAP system</summary>
        string OSSapConfigurationSapFqdn { get; set; }
        /// <summary>The software configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISoftwareConfiguration SoftwareConfiguration { get; set; }
        /// <summary>The SAP software installation Type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapSoftwareInstallationType? SoftwareConfigurationSoftwareInstallationType { get; set; }

    }
}