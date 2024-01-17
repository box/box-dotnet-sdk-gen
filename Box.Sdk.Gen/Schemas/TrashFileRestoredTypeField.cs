using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFileRestoredTypeField>))]
    public enum TrashFileRestoredTypeField {
        [Description("file")]
        File
    }
}