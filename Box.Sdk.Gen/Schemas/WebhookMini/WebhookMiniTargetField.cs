using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

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
        [JsonConverter(typeof(StringEnumConverter<WebhookMiniTargetTypeField>))]
        public StringEnum<WebhookMiniTargetTypeField>? Type { get; init; }

        public WebhookMiniTargetField() {
            
        }
    }
}