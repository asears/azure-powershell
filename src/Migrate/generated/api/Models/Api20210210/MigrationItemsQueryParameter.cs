namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Query parameter to enumerate migration items.</summary>
    public partial class MigrationItemsQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationItemsQueryParameter,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrationItemsQueryParameterInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The replication provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Backing field for <see cref="SourceContainerName" /> property.</summary>
        private string _sourceContainerName;

        /// <summary>The source container name filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceContainerName { get => this._sourceContainerName; set => this._sourceContainerName = value; }

        /// <summary>Backing field for <see cref="SourceFabricName" /> property.</summary>
        private string _sourceFabricName;

        /// <summary>The source fabric name filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SourceFabricName { get => this._sourceFabricName; set => this._sourceFabricName = value; }

        /// <summary>Creates an new <see cref="MigrationItemsQueryParameter" /> instance.</summary>
        public MigrationItemsQueryParameter()
        {

        }
    }
    /// Query parameter to enumerate migration items.
    public partial interface IMigrationItemsQueryParameter :
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
        /// <summary>The source container name filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source container name filter.",
        SerializedName = @"sourceContainerName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceContainerName { get; set; }
        /// <summary>The source fabric name filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source fabric name filter.",
        SerializedName = @"sourceFabricName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceFabricName { get; set; }

    }
    /// Query parameter to enumerate migration items.
    internal partial interface IMigrationItemsQueryParameterInternal

    {
        /// <summary>The replication provider type.</summary>
        string InstanceType { get; set; }
        /// <summary>The source container name filter.</summary>
        string SourceContainerName { get; set; }
        /// <summary>The source fabric name filter.</summary>
        string SourceFabricName { get; set; }

    }
}