using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
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
        public string? CreatedAt { get; set; } = default;

        [JsonPropertyName("trigger")]
        public WebhookInvocationTriggerField? Trigger { get; set; } = default;

        [JsonPropertyName("source")]
        public WebhookInvocationSourceField? Source { get; set; } = default;

        public WebhookInvocation() {
            
        }
    }
}