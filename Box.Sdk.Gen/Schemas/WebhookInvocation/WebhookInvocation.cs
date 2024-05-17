using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WebhookInvocation {
        /// <summary>
        /// The unique identifier for this webhook invocation
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `webhook_event`
        /// </summary>
        [JsonPropertyName("type")]
        public WebhookInvocationTypeField? Type { get; init; }

        [JsonPropertyName("webhook")]
        public Webhook? Webhook { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        /// <summary>
        /// A timestamp identifying the time that
        /// the webhook event was triggered.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("trigger")]
        public WebhookInvocationTriggerField? Trigger { get; init; }

        [JsonPropertyName("source")]
        public FileOrFolder? Source { get; init; }

        public WebhookInvocation() {
            
        }
    }
}