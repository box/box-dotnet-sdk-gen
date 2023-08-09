using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WebhookInvocation {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WebhookInvocationTypeField Type { get; }

        [JsonPropertyName("webhook")]
        public Webhook Webhook { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("trigger")]
        public WebhookInvocationTriggerField Trigger { get; }

        [JsonPropertyName("source")]
        public WebhookInvocationSourceField Source { get; }

        public WebhookInvocation(string id, WebhookInvocationTypeField type, Webhook webhook, UserMini createdBy, string createdAt, WebhookInvocationTriggerField trigger, WebhookInvocationSourceField source) {
            Id = id;
            Type = type;
            Webhook = webhook;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            Trigger = trigger;
            Source = source;
        }
    }
}