using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Outcome {
        /// <summary>
        /// ID of a specific outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("collaborators")]
        public CollaboratorVariable? Collaborators { get; set; } = default;

        [JsonPropertyName("completion_rule")]
        public CompletionRuleVariable? CompletionRule { get; set; } = default;

        [JsonPropertyName("file_collaborator_role")]
        public RoleVariable? FileCollaboratorRole { get; set; } = default;

        [JsonPropertyName("task_collaborators")]
        public CollaboratorVariable? TaskCollaborators { get; set; } = default;

        [JsonPropertyName("role")]
        public RoleVariable? Role { get; set; } = default;

        public Outcome(string id) {
            Id = id;
        }
    }
}