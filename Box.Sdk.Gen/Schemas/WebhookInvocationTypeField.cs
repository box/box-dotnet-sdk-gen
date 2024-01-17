using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebhookInvocationTypeField>))]
    public enum WebhookInvocationTypeField {
        [Description("webhook_event")]
        WebhookEvent
    }
}