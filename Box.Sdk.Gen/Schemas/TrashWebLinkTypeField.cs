using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashWebLinkTypeField>))]
    public enum TrashWebLinkTypeField {
        [Description("web_link")]
        WebLink
    }
}