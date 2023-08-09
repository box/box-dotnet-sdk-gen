using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public UserBaseTypeField Type { get; }

        public UserBase(string id, UserBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}