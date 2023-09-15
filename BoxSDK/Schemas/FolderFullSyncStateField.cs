using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderFullSyncStateField>))]
    public enum FolderFullSyncStateField {
        [Description("synced")]
        Synced,
        [Description("not_synced")]
        NotSynced,
        [Description("partially_synced")]
        PartiallySynced
    }
}