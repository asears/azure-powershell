namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>ApplyRecoveryPoint input specific to HyperVReplicaAzure provider.</summary>
    public partial class HyperVReplicaAzureApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureApplyRecoveryPointInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureApplyRecoveryPointInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput __applyRecoveryPointProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ApplyRecoveryPointProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType = value ; }

        /// <summary>Backing field for <see cref="PrimaryKekCertificatePfx" /> property.</summary>
        private string _primaryKekCertificatePfx;

        /// <summary>The primary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryKekCertificatePfx { get => this._primaryKekCertificatePfx; set => this._primaryKekCertificatePfx = value; }

        /// <summary>Backing field for <see cref="SecondaryKekCertificatePfx" /> property.</summary>
        private string _secondaryKekCertificatePfx;

        /// <summary>The secondary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SecondaryKekCertificatePfx { get => this._secondaryKekCertificatePfx; set => this._secondaryKekCertificatePfx = value; }

        /// <summary>
        /// Creates an new <see cref="HyperVReplicaAzureApplyRecoveryPointInput" /> instance.
        /// </summary>
        public HyperVReplicaAzureApplyRecoveryPointInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
        }
    }
    /// ApplyRecoveryPoint input specific to HyperVReplicaAzure provider.
    public partial interface IHyperVReplicaAzureApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput
    {
        /// <summary>The primary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary kek certificate pfx.",
        SerializedName = @"primaryKekCertificatePfx",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKekCertificatePfx { get; set; }
        /// <summary>The secondary kek certificate pfx.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secondary kek certificate pfx.",
        SerializedName = @"secondaryKekCertificatePfx",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKekCertificatePfx { get; set; }

    }
    /// ApplyRecoveryPoint input specific to HyperVReplicaAzure provider.
    internal partial interface IHyperVReplicaAzureApplyRecoveryPointInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal
    {
        /// <summary>The primary kek certificate pfx.</summary>
        string PrimaryKekCertificatePfx { get; set; }
        /// <summary>The secondary kek certificate pfx.</summary>
        string SecondaryKekCertificatePfx { get; set; }

    }
}