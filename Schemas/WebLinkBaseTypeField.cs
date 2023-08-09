using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebLinkBaseTypeField>))]
    public enum WebLinkBaseTypeField {
        [Description("web_link")]
        WebLink
    }
}