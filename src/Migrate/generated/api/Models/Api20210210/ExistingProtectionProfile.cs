namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Existing storage account input.</summary>
    public partial class ExistingProtectionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingProtectionProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingProtectionProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails __protectionProfileCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetails();

        /// <summary>Backing field for <see cref="ProtectionProfileId" /> property.</summary>
        private string _protectionProfileId;

        /// <summary>The protection profile Arm Id. Throw error, if resource does not exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProtectionProfileId { get => this._protectionProfileId; set => this._protectionProfileId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)__protectionProfileCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)__protectionProfileCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="ExistingProtectionProfile" /> instance.</summary>
        public ExistingProtectionProfile()
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
            await eventListener.AssertNotNull(nameof(__protectionProfileCustomDetails), __protectionProfileCustomDetails);
            await eventListener.AssertObjectIsValid(nameof(__protectionProfileCustomDetails), __protectionProfileCustomDetails);
        }
    }
    /// Existing storage account input.
    public partial interface IExistingProtectionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails
    {
        /// <summary>The protection profile Arm Id. Throw error, if resource does not exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The protection profile Arm Id. Throw error, if resource does not exists.",
        SerializedName = @"protectionProfileId",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionProfileId { get; set; }

    }
    /// Existing storage account input.
    internal partial interface IExistingProtectionProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal
    {
        /// <summary>The protection profile Arm Id. Throw error, if resource does not exists.</summary>
        string ProtectionProfileId { get; set; }

    }
}