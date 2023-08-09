using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillCardsMetadata {
        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; }

        [JsonPropertyName("$id")]
        public string Id { get; }

        [JsonPropertyName("$parent")]
        public string Parent { get; }

        [JsonPropertyName("$scope")]
        public string Scope { get; }

        [JsonPropertyName("$template")]
        public string Template { get; }

        [JsonPropertyName("$type")]
        public string Type { get; }

        [JsonPropertyName("$typeVersion")]
        public int? TypeVersion { get; }

        [JsonPropertyName("$version")]
        public int? Version { get; }

        [JsonPropertyName("cards")]
        public IReadOnlyList<SkillCardsMetadataCardsField> Cards { get; }

        public SkillCardsMetadata(bool? canEdit, string id, string parent, string scope, string template, string type, int? typeVersion, int? version, IReadOnlyList<SkillCardsMetadataCardsField> cards) {
            CanEdit = canEdit;
            Id = id;
            Parent = parent;
            Scope = scope;
            Template = template;
            Type = type;
            TypeVersion = typeVersion;
            Version = version;
            Cards = cards;
        }
    }
}