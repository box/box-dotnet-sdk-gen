using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateWebhookByIdRequestBodyTargetField {
        /// <summary>
        /// The ID of the item to trigger a webhook
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of item to trigger a webhook
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateWebhookByIdRequestBodyTargetTypeField? Type { get; init; }

        public UpdateWebhookByIdRequestBodyTargetField() {
            
        }
    }
}