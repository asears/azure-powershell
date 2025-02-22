namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input to create vault setting.</summary>
    public partial class VaultSettingCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultSettingCreationInputProperties()); set { {_property = value;} } }

        /// <summary>The migration solution Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MigrationSolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputPropertiesInternal)Property).MigrationSolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputPropertiesInternal)Property).MigrationSolutionId = value ; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputProperties _property;

        /// <summary>Vault setting creation input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultSettingCreationInputProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="VaultSettingCreationInput" /> instance.</summary>
        public VaultSettingCreationInput()
        {

        }
    }
    /// Input to create vault setting.
    public partial interface IVaultSettingCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The migration solution Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The migration solution Id.",
        SerializedName = @"migrationSolutionId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationSolutionId { get; set; }

    }
    /// Input to create vault setting.
    internal partial interface IVaultSettingCreationInputInternal

    {
        /// <summary>The migration solution Id.</summary>
        string MigrationSolutionId { get; set; }
        /// <summary>Vault setting creation input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputProperties Property { get; set; }

    }
}