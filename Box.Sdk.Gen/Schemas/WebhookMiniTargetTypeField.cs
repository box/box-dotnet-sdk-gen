using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebhookMiniTargetTypeField>))]
    public enum WebhookMiniTargetTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}