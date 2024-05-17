using Unions;
using System.Text.Json.Serialization;

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
        public WebhookMiniTypeField? Type { get; init; }

        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public WebhookMiniTargetField? Target { get; init; }

        public WebhookMini() {
            
        }
    }
}