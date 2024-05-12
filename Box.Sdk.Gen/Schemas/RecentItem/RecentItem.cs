using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RecentItem {
        /// <summary>
        /// `recent_item`
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        [JsonPropertyName("item")]
        public FileFullOrFolderFullOrWebLink? Item { get; set; } = default;

        /// <summary>
        /// The most recent type of access the user performed on
        /// the item.
        /// </summary>
        [JsonPropertyName("interaction_type")]
        public RecentItemInteractionTypeField? InteractionType { get; set; } = default;

        /// <summary>
        /// The time of the most recent interaction.
        /// </summary>
        [JsonPropertyName("interacted_at")]
        public System.DateTimeOffset? InteractedAt { get; set; } = default;

        /// <summary>
        /// If the item was accessed through a shared link it will appear here,
        /// otherwise this will be null.
        /// </summary>
        [JsonPropertyName("interaction_shared_link")]
        public string? InteractionSharedLink { get; set; } = default;

        public RecentItem() {
            
        }
    }
}