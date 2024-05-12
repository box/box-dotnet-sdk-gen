using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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