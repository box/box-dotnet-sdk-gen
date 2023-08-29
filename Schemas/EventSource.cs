using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EventSource {
        /// <summary>
        /// The type of the item that the event
        /// represents. Can be `file` or `folder`.
        /// 
        /// </summary>
        [JsonPropertyName("item_type")]
        public EventSourceItemTypeField ItemType { get; set; }

        /// <summary>
        /// The unique identifier that represents the
        /// item.
        /// 
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The name of the item.
        /// 
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// The object containing classification information for the item that
        /// triggered the event. This field will not appear if the item does not
        /// have a classification set.
        /// </summary>
        [JsonPropertyName("classification")]
        public EventSourceClassificationField? Classification { get; set; } = default;

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; set; } = default;

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; set; } = default;

        public EventSource(EventSourceItemTypeField itemType, string itemId, string itemName) {
            ItemType = itemType;
            ItemId = itemId;
            ItemName = itemName;
        }
    }
}