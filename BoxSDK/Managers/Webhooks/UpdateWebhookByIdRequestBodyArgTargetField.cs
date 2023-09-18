using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebhookByIdRequestBodyArgTargetField {
        /// <summary>
        /// The ID of the item to trigger a webhook
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of item to trigger a webhook
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateWebhookByIdRequestBodyArgTargetFieldTypeField? Type { get; set; } = default;

        public UpdateWebhookByIdRequestBodyArgTargetField() {
            
        }
    }
}