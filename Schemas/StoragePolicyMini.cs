using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class StoragePolicyMini {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public StoragePolicyMiniTypeField Type { get; }

        public StoragePolicyMini(string id, StoragePolicyMiniTypeField type) {
            Id = id;
            Type = type;
        }
    }
}