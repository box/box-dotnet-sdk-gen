using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullExpiringEmbedLinkTokenTypeField>))]
    public enum FileFullExpiringEmbedLinkTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}