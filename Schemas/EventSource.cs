using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EventSource {
        [JsonPropertyName("item_type")]
        public EventSourceItemTypeField ItemType { get; }

        [JsonPropertyName("item_id")]
        public string ItemId { get; }

        [JsonPropertyName("item_name")]
        public string ItemName { get; }

        [JsonPropertyName("classification")]
        public EventSourceClassificationField Classification { get; }

        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        public EventSource(EventSourceItemTypeField itemType, string itemId, string itemName, EventSourceClassificationField classification, FolderMini parent, UserMini ownedBy) {
            ItemType = itemType;
            ItemId = itemId;
            ItemName = itemName;
            Classification = classification;
            Parent = parent;
            OwnedBy = ownedBy;
        }
    }
}