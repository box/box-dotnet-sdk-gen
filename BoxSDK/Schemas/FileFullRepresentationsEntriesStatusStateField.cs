using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullRepresentationsEntriesStatusStateField>))]
    public enum FileFullRepresentationsEntriesStatusStateField {
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