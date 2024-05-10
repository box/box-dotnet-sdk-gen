using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WebhookInvocation {
        /// <summary>
        /// The unique identifier for this webhook invocation
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `webhook_event`
        /// </summary>
        [JsonPropertyName("type")]
        public WebhookInvocationTypeField? Type { get; set; } = default;

        [JsonPropertyName("webhook")]
        public Webhook? Webhook { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// A timestamp identifying the time that
        /// the webhook event was triggered.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        [JsonPropertyName("trigger")]
        public WebhookInvocationTriggerField? Trigger { get; set; } = default;

        [JsonPropertyName("source")]
        public FileOrFolder? Source { get; set; } = default;

        public WebhookInvocation() {
            
        }
    }
}