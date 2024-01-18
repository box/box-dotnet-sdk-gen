using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullExpiringEmbedLinkTokenTypeField>))]
    public enum FileFullExpiringEmbedLinkTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}