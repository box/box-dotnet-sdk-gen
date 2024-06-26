using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RecentItem {
        /// <summary>
        /// `recent_item`
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        [JsonPropertyName("item")]
        public FileFullOrFolderFullOrWebLink? Item { get; init; }

        /// <summary>
        /// The most recent type of access the user performed on
        /// the item.
        /// </summary>
        [JsonPropertyName("interaction_type")]
        [JsonConverter(typeof(StringEnumConverter<RecentItemInteractionTypeField>))]
        public StringEnum<RecentItemInteractionTypeField>? InteractionType { get; init; }

        /// <summary>
        /// The time of the most recent interaction.
        /// </summary>
        [JsonPropertyName("interacted_at")]
        public System.DateTimeOffset? InteractedAt { get; init; }

        /// <summary>
        /// If the item was accessed through a shared link it will appear here,
        /// otherwise this will be null.
        /// </summary>
        [JsonPropertyName("interaction_shared_link")]
        public string? InteractionSharedLink { get; init; }

        public RecentItem() {
            
        }
    }
}