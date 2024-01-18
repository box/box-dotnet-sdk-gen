using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SkillCardsMetadata {
        /// <summary>
        /// Whether the user can edit this metadata
        /// </summary>
        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; set; } = default;

        /// <summary>
        /// A UUID to identify the metadata object
        /// </summary>
        [JsonPropertyName("$id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// An ID for the parent folder
        /// </summary>
        [JsonPropertyName("$parent")]
        public string? Parent { get; set; } = default;

        /// <summary>
        /// An ID for the scope in which this template
        /// has been applied
        /// </summary>
        [JsonPropertyName("$scope")]
        public string? Scope { get; set; } = default;

        /// <summary>
        /// The name of the template
        /// </summary>
        [JsonPropertyName("$template")]
        public string? Template { get; set; } = default;

        /// <summary>
        /// A unique identifier for the "type" of this instance. This is an internal
        /// system property and should not be used by a client application.
        /// </summary>
        [JsonPropertyName("$type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// The last-known version of the template of the object. This is an internal
        /// system property and should not be used by a client application.
        /// </summary>
        [JsonPropertyName("$typeVersion")]
        public long? TypeVersion { get; set; } = default;

        /// <summary>
        /// The version of the metadata object. Starts at 0 and increases every time
        /// a user-defined property is modified.
        /// </summary>
        [JsonPropertyName("$version")]
        public long? Version { get; set; } = default;

        /// <summary>
        /// A list of Box Skill cards that have been applied to this file.
        /// </summary>
        [JsonPropertyName("cards")]
        public IReadOnlyList<KeywordSkillCardOrStatusSkillCardOrTimelineSkillCardOrTranscriptSkillCard>? Cards { get; set; } = default;

        public SkillCardsMetadata() {
            
        }
    }
}