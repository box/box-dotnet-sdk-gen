using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicyMini {
        /// <summary>
        /// The unique identifier for this storage policy
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `storage_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public StoragePolicyMiniTypeField Type { get; set; }

        public StoragePolicyMini(string id, StoragePolicyMiniTypeField type = StoragePolicyMiniTypeField.StoragePolicy) {
            Id = id;
            Type = type;
        }
    }
}