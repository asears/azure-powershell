namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Hyperscale node edition capabilities.</summary>
    public partial class HyperscaleNodeEditionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapability,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for SupportedNodeType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal.SupportedNodeType { get => this._supportedNodeType; set { {_supportedNodeType = value;} } }

        /// <summary>Internal Acessors for SupportedServerVersion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal.SupportedServerVersion { get => this._supportedServerVersion; set { {_supportedServerVersion = value;} } }

        /// <summary>Internal Acessors for SupportedStorageEdition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHyperscaleNodeEditionCapabilityInternal.SupportedStorageEdition { get => this._supportedStorageEdition; set { {_supportedStorageEdition = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Server edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="SupportedNodeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[] _supportedNodeType;

        /// <summary>The list of Node Types supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[] SupportedNodeType { get => this._supportedNodeType; }

        /// <summary>Backing field for <see cref="SupportedServerVersion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[] _supportedServerVersion;

        /// <summary>The list of server versions supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[] SupportedServerVersion { get => this._supportedServerVersion; }

        /// <summary>Backing field for <see cref="SupportedStorageEdition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[] _supportedStorageEdition;

        /// <summary>The list of editions supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[] SupportedStorageEdition { get => this._supportedStorageEdition; }

        /// <summary>Creates an new <see cref="HyperscaleNodeEditionCapability" /> instance.</summary>
        public HyperscaleNodeEditionCapability()
        {

        }
    }
    /// Hyperscale node edition capabilities.
    public partial interface IHyperscaleNodeEditionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>Server edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Server edition name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>The list of Node Types supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of Node Types supported by this server edition.",
        SerializedName = @"supportedNodeTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[] SupportedNodeType { get;  }
        /// <summary>The list of server versions supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of server versions supported by this server edition.",
        SerializedName = @"supportedServerVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[] SupportedServerVersion { get;  }
        /// <summary>The list of editions supported by this server edition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of editions supported by this server edition.",
        SerializedName = @"supportedStorageEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[] SupportedStorageEdition { get;  }

    }
    /// Hyperscale node edition capabilities.
    internal partial interface IHyperscaleNodeEditionCapabilityInternal

    {
        /// <summary>Server edition name</summary>
        string Name { get; set; }
        /// <summary>The status</summary>
        string Status { get; set; }
        /// <summary>The list of Node Types supported by this server edition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability[] SupportedNodeType { get; set; }
        /// <summary>The list of server versions supported by this server edition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability[] SupportedServerVersion { get; set; }
        /// <summary>The list of editions supported by this server edition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageEditionCapability[] SupportedStorageEdition { get; set; }

    }
}