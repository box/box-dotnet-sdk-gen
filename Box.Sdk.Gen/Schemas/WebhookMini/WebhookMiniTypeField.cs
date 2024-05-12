using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebhookMiniTypeField>))]
    public enum WebhookMiniTypeField {
        [Description("webhook")]
        Webhook
    }
}