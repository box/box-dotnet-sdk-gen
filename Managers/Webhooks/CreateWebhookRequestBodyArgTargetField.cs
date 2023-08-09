using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebhookRequestBodyArgTargetField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateWebhookRequestBodyArgTargetFieldTypeField Type { get; }

        public CreateWebhookRequestBodyArgTargetField(string id, CreateWebhookRequestBodyArgTargetFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}