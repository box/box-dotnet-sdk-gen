using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowMini {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WorkflowMiniTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; }

        public WorkflowMini(string id, WorkflowMiniTypeField type, string name, string description, bool? isEnabled) {
            Id = id;
            Type = type;
            Name = name;
            Description = description;
            IsEnabled = isEnabled;
        }
    }
}