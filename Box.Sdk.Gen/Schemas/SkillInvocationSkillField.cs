using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocationSkillField {
        /// <summary>
        /// The unique identifier for this skill
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `skill`
        /// </summary>
        [JsonPropertyName("type")]
        public SkillInvocationSkillTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the skill
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The client ID of the application
        /// </summary>
        [JsonPropertyName("api_key")]
        public string? ApiKey { get; set; } = default;

        public SkillInvocationSkillField() {
            
        }
    }
}