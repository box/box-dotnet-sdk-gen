using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CommentBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CommentBaseTypeField Type { get; }

        public CommentBase(string id, CommentBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}