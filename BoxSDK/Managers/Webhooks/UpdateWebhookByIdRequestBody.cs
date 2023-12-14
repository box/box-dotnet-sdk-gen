using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebhookByIdRequestBody {
        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public UpdateWebhookByIdRequestBodyTargetField? Target { get; set; } = default;

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
        public IReadOnlyList<UpdateWebhookByIdRequestBodyTriggersField>? Triggers { get; set; } = default;

        public UpdateWebhookByIdRequestBody() {
            
        }
    }
}