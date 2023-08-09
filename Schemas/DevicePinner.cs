using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class DevicePinner {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public DevicePinnerTypeField Type { get; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; }

        public DevicePinner(string id, DevicePinnerTypeField type, UserMini ownedBy, string productName) {
            Id = id;
            Type = type;
            OwnedBy = ownedBy;
            ProductName = productName;
        }
    }
}