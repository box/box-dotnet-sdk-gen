using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashWebLinkRestoredTypeField>))]
    public enum TrashWebLinkRestoredTypeField {
        [Description("web_link")]
        WebLink
    }
}