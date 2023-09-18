using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullRepresentationsFieldEntriesFieldStatusFieldStateField>))]
    public enum FileFullRepresentationsFieldEntriesFieldStatusFieldStateField {
        [Description("success")]
        Success,
        [Description("viewable")]
        Viewable,
        [Description("pending")]
        Pending,
        [Description("none")]
        None
    }
}