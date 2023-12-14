using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashWebLinkPathCollectionEntriesTypeField>))]
    public enum TrashWebLinkPathCollectionEntriesTypeField {
        [Description("folder")]
        Folder
    }
}