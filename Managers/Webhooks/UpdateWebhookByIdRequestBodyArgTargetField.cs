using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebhookByIdRequestBodyArgTargetField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public UpdateWebhookByIdRequestBodyArgTargetFieldTypeField Type { get; }

        public UpdateWebhookByIdRequestBodyArgTargetField(string id, UpdateWebhookByIdRequestBodyArgTargetFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}