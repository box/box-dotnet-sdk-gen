using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class WebhookMini {
        /// <summary>
        /// The unique identifier for this webhook.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `webhook`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<WebhookMiniTypeField>))]
        public StringEnum<WebhookMiniTypeField>? Type { get; init; }

        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public WebhookMiniTargetField? Target { get; init; }

        public WebhookMini() {
            
        }
    }
}