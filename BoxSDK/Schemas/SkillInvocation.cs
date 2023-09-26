using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocation {
        /// <summary>
        /// `skill_invocation`
        /// </summary>
        [JsonPropertyName("type")]
        public SkillInvocationTypeField? Type { get; set; } = default;

        /// <summary>
        /// Unique identifier for the invocation request.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        [JsonPropertyName("skill")]
        public SkillInvocationSkillField? Skill { get; set; } = default;

        /// <summary>
        /// The read-only and read-write access tokens for this item
        /// </summary>
        [JsonPropertyName("token")]
        public SkillInvocationTokenField? Token { get; set; } = default;

        /// <summary>
        /// The details status of this event.
        /// </summary>
        [JsonPropertyName("status")]
        public SkillInvocationStatusField? Status { get; set; } = default;

        /// <summary>
        /// The time this invocation was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// Action that triggered the invocation
        /// </summary>
        [JsonPropertyName("trigger")]
        public string? Trigger { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public SkillInvocationEnterpriseField? Enterprise { get; set; } = default;

        [JsonPropertyName("source")]
        public FileOrFolder? Source { get; set; } = default;

        [JsonPropertyName("event")]
        public Event? Event { get; set; } = default;

        public SkillInvocation() {
            
        }
    }
}