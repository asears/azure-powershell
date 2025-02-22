namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Supported operating systems property.</summary>
    public partial class SupportedOSProperty :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSPropertyInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The replication provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Backing field for <see cref="SupportedOS" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails[] _supportedOS;

        /// <summary>The list of supported operating systems.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails[] SupportedOS { get => this._supportedOS; set => this._supportedOS = value; }

        /// <summary>Creates an new <see cref="SupportedOSProperty" /> instance.</summary>
        public SupportedOSProperty()
        {

        }
    }
    /// Supported operating systems property.
    public partial interface ISupportedOSProperty :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The replication provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replication provider type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }
        /// <summary>The list of supported operating systems.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of supported operating systems.",
        SerializedName = @"supportedOs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails[] SupportedOS { get; set; }

    }
    /// Supported operating systems property.
    internal partial interface ISupportedOSPropertyInternal

    {
        /// <summary>The replication provider type.</summary>
        string InstanceType { get; set; }
        /// <summary>The list of supported operating systems.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails[] SupportedOS { get; set; }

    }
}