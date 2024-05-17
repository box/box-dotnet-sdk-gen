using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class WebhookMiniTargetField {
        /// <summary>
        /// The ID of the item to trigger a webhook
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of item to trigger a webhook
        /// </summary>
        [JsonPropertyName("type")]
        public WebhookMiniTargetTypeField? Type { get; init; }

        public WebhookMiniTargetField() {
            
        }
    }
}