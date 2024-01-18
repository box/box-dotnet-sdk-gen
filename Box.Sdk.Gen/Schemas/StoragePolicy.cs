using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class StoragePolicy : StoragePolicyMini {
        /// <summary>
        /// A descriptive name of the region
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public StoragePolicy(string id, StoragePolicyMiniTypeField type) : base(id, type) {
            
        }
    }
}