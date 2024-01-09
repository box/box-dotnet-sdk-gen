using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateFolderRequestBodySyncStateField>))]
    public enum CreateFolderRequestBodySyncStateField {
        [Description("synced")]
        Synced,
        [Description("not_synced")]
        NotSynced,
        [Description("partially_synced")]
        PartiallySynced
    }
}