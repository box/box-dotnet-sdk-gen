using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class EventSource {
        /// <summary>
        /// The type of the item that the event
        /// represents. Can be `file` or `folder`.
        /// 
        /// </summary>
        [JsonPropertyName("item_type")]
        [JsonConverter(typeof(StringEnumConverter<EventSourceItemTypeField>))]
        public StringEnum<EventSourceItemTypeField> ItemType { get; }

        /// <summary>
        /// The unique identifier that represents the
        /// item.
        /// 
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; }

        /// <summary>
        /// The name of the item.
        /// 
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; }

        /// <summary>
        /// The object containing classification information for the item that
        /// triggered the event. This field will not appear if the item does not
        /// have a classification set.
        /// </summary>
        [JsonPropertyName("classification")]
        public EventSourceClassificationField? Classification { get; init; }

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; init; }

        public EventSource(EventSourceItemTypeField itemType, string itemId, string itemName) {
            ItemType = itemType;
            ItemId = itemId;
            ItemName = itemName;
        }
        
        [JsonConstructorAttribute]
        internal EventSource(StringEnum<EventSourceItemTypeField> itemType, string itemId, string itemName) {
            ItemType = itemType;
            ItemId = itemId;
            ItemName = itemName;
        }
    }
}