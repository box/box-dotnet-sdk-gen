using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Webhook : WebhookMini {
        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("triggers")]
        public IReadOnlyList<WebhookTriggersField> Triggers { get; }

        public Webhook(string id, WebhookMiniTypeField type, WebhookMiniTargetField target, UserMini createdBy, string createdAt, string address, IReadOnlyList<WebhookTriggersField> triggers) : base(id, type, target) {
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            Address = address;
            Triggers = triggers;
        }
    }
}