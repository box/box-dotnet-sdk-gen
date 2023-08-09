using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataFull : Metadata {
        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; }

        [JsonPropertyName("$id")]
        public string Id { get; }

        [JsonPropertyName("$type")]
        public string Type { get; }

        [JsonPropertyName("$typeVersion")]
        public int? TypeVersion { get; }

        [JsonPropertyName("extraData")]
        public Dictionary<string, string> ExtraData { get; }

        public MetadataFull(string parent, string template, string scope, int? version, bool? canEdit, string id, string type, int? typeVersion, Dictionary<string, string> extraData) : base(parent, template, scope, version) {
            CanEdit = canEdit;
            Id = id;
            Type = type;
            TypeVersion = typeVersion;
            ExtraData = extraData;
        }
    }
}