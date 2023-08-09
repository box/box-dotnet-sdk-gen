using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class StoragePolicy : StoragePolicyMini {
        [JsonPropertyName("name")]
        public string Name { get; }

        public StoragePolicy(string id, StoragePolicyMiniTypeField type, string name) : base(id, type) {
            Name = name;
        }
    }
}