namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Location capabilities.</summary>
    public partial class CapabilityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GeoBackupSupported" /> property.</summary>
        private bool? _geoBackupSupported;

        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public bool? GeoBackupSupported { get => this._geoBackupSupported; }

        /// <summary>Internal Acessors for GeoBackupSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.GeoBackupSupported { get => this._geoBackupSupported; set { {_geoBackupSupported = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for SupportedFlexibleServerEdition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; set { {_supportedFlexibleServerEdition = value;} } }

        /// <summary>Internal Acessors for SupportedHyperscaleNodeEdition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.SupportedHyperscaleNodeEdition { get => this._supportedHyperscaleNodeEdition; set { {_supportedHyperscaleNodeEdition = value;} } }

        /// <summary>Internal Acessors for Zone</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.Zone { get => this._zone; set { {_zone = value;} } }

        /// <summary>Internal Acessors for ZoneRedundantHaAndGeoBackupSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.ZoneRedundantHaAndGeoBackupSupported { get => this._zoneRedundantHaAndGeoBackupSupported; set { {_zoneRedundantHaAndGeoBackupSupported = value;} } }

        /// <summary>Internal Acessors for ZoneRedundantHaSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ICapabilityPropertiesInternal.ZoneRedundantHaSupported { get => this._zoneRedundantHaSupported; set { {_zoneRedundantHaSupported = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="SupportedFlexibleServerEdition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[] _supportedFlexibleServerEdition;

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[] SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; }

        /// <summary>Backing field for <see cref="SupportedHyperscaleNodeEdition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[] _supportedHyperscaleNodeEdition;

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[] SupportedHyperscaleNodeEdition { get => this._supportedHyperscaleNodeEdition; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string _zone;

        /// <summary>zone name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Zone { get => this._zone; }

        /// <summary>Backing field for <see cref="ZoneRedundantHaAndGeoBackupSupported" /> property.</summary>
        private bool? _zoneRedundantHaAndGeoBackupSupported;

        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public bool? ZoneRedundantHaAndGeoBackupSupported { get => this._zoneRedundantHaAndGeoBackupSupported; }

        /// <summary>Backing field for <see cref="ZoneRedundantHaSupported" /> property.</summary>
        private bool? _zoneRedundantHaSupported;

        /// <summary>
        /// A value indicating whether a new server in this region can support multi zone HA.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public bool? ZoneRedundantHaSupported { get => this._zoneRedundantHaSupported; }

        /// <summary>Creates an new <see cref="CapabilityProperties" /> instance.</summary>
        public CapabilityProperties()
        {

        }
    }
    /// Location capabilities.
    public partial interface ICapabilityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether a new server in this region can have geo-backups to paired region.",
        SerializedName = @"geoBackupSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? GeoBackupSupported { get;  }
        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"supportedFlexibleServerEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[] SupportedFlexibleServerEdition { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"supportedHyperscaleNodeEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[] SupportedHyperscaleNodeEdition { get;  }
        /// <summary>zone name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"zone name",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(string) })]
        string Zone { get;  }
        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether a new server in this region can have geo-backups to paired region.",
        SerializedName = @"zoneRedundantHaAndGeoBackupSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZoneRedundantHaAndGeoBackupSupported { get;  }
        /// <summary>
        /// A value indicating whether a new server in this region can support multi zone HA.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether a new server in this region can support multi zone HA.",
        SerializedName = @"zoneRedundantHaSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ZoneRedundantHaSupported { get;  }

    }
    /// Location capabilities.
    internal partial interface ICapabilityPropertiesInternal

    {
        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        bool? GeoBackupSupported { get; set; }
        /// <summary>The status</summary>
        string Status { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IFlexibleServerEditionCapability[] SupportedFlexibleServerEdition { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability[] SupportedHyperscaleNodeEdition { get; set; }
        /// <summary>zone name</summary>
        string Zone { get; set; }
        /// <summary>
        /// A value indicating whether a new server in this region can have geo-backups to paired region.
        /// </summary>
        bool? ZoneRedundantHaAndGeoBackupSupported { get; set; }
        /// <summary>
        /// A value indicating whether a new server in this region can support multi zone HA.
        /// </summary>
        bool? ZoneRedundantHaSupported { get; set; }

    }
}