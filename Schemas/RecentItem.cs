using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class RecentItem {
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("item")]
        public RecentItemItemField Item { get; }

        [JsonPropertyName("interaction_type")]
        public RecentItemInteractionTypeField InteractionType { get; }

        [JsonPropertyName("interacted_at")]
        public string InteractedAt { get; }

        [JsonPropertyName("interaction_shared_link")]
        public string InteractionSharedLink { get; }

        public RecentItem(string type, RecentItemItemField item, RecentItemInteractionTypeField interactionType, string interactedAt, string interactionSharedLink) {
            Type = type;
            Item = item;
            InteractionType = interactionType;
            InteractedAt = interactedAt;
            InteractionSharedLink = interactionSharedLink;
        }
    }
}