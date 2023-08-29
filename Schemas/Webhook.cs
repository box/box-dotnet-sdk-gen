using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Webhook : WebhookMini {
        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// A timestamp identifying the time that
        /// the webhook was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// The URL that is notified by this webhook
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get; set; } = default;

        /// <summary>
        /// An array of event names that this webhook is
        /// to be triggered for
        /// </summary>
        [JsonPropertyName("triggers")]
        public IReadOnlyList<WebhookTriggersField>? Triggers { get; set; } = default;

        public Webhook() {
            
        }
    }
}