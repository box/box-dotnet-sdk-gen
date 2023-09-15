using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebhookMiniTargetField {
        /// <summary>
        /// The ID of the item to trigger a webhook
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of item to trigger a webhook
        /// </summary>
        [JsonPropertyName("type")]
        public WebhookMiniTargetFieldTypeField? Type { get; set; } = default;

        public WebhookMiniTargetField() {
            
        }
    }
}