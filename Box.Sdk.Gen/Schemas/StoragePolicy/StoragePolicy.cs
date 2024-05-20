using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicy : StoragePolicyMini {
        /// <summary>
        /// A descriptive name of the region
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public StoragePolicy(string id, StoragePolicyMiniTypeField type = StoragePolicyMiniTypeField.StoragePolicy) : base(id, type) {
            
        }
    }
}