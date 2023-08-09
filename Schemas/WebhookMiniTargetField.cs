using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebhookMiniTargetField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WebhookMiniTargetFieldTypeField Type { get; }

        public WebhookMiniTargetField(string id, WebhookMiniTargetFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}