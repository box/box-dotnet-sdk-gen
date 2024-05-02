using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<AiTextGenItemsTypeField>))]
    public enum AiTextGenItemsTypeField {
        [Description("file")]
        File
    }
}