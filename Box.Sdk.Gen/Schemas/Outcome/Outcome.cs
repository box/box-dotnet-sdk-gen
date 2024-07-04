using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Outcome {
        /// <summary>
        /// ID of a specific outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("collaborators")]
        public CollaboratorVariable? Collaborators { get; init; }

        [JsonPropertyName("completion_rule")]
        public CompletionRuleVariable? CompletionRule { get; init; }

        [JsonPropertyName("file_collaborator_role")]
        public RoleVariable? FileCollaboratorRole { get; init; }

        [JsonPropertyName("task_collaborators")]
        public CollaboratorVariable? TaskCollaborators { get; init; }

        [JsonPropertyName("role")]
        public RoleVariable? Role { get; init; }

        public Outcome(string id) {
            Id = id;
        }
    }
}