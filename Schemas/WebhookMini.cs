using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebhookMini {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WebhookMiniTypeField Type { get; }

        [JsonPropertyName("target")]
        public WebhookMiniTargetField Target { get; }

        public WebhookMini(string id, WebhookMiniTypeField type, WebhookMiniTargetField target) {
            Id = id;
            Type = type;
            Target = target;
        }
    }
}