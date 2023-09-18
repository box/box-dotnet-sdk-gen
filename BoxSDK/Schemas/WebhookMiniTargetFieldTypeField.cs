using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebhookMiniTargetFieldTypeField>))]
    public enum WebhookMiniTargetFieldTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}