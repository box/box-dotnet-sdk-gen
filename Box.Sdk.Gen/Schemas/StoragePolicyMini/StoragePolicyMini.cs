using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyMini {
        /// <summary>
        /// The unique identifier for this storage policy
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `storage_policy`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StoragePolicyMiniTypeField>))]
        public StringEnum<StoragePolicyMiniTypeField> Type { get; }

        public StoragePolicyMini(string id, StoragePolicyMiniTypeField type = StoragePolicyMiniTypeField.StoragePolicy) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal StoragePolicyMini(string id, StringEnum<StoragePolicyMiniTypeField> type) {
            Id = id;
            Type = StoragePolicyMiniTypeField.StoragePolicy;
        }
    }
}