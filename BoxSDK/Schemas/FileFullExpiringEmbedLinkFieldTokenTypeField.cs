using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullExpiringEmbedLinkFieldTokenTypeField>))]
    public enum FileFullExpiringEmbedLinkFieldTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}