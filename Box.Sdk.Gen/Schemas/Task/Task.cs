using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Task {
        /// <summary>
        /// The unique identifier for this task
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `task`
        /// </summary>
        [JsonPropertyName("type")]
        public TaskTypeField? Type { get; init; }

        [JsonPropertyName("item")]
        public FileMini? Item { get; init; }

        /// <summary>
        /// When the task is due
        /// </summary>
        [JsonPropertyName("due_at")]
        public System.DateTimeOffset? DueAt { get; init; }

        /// <summary>
        /// The type of task the task assignee will be prompted to
        /// perform.
        /// </summary>
        [JsonPropertyName("action")]
        public TaskActionField? Action { get; init; }

        /// <summary>
        /// A message that will be included with the task
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        [JsonPropertyName("task_assignment_collection")]
        public TaskAssignments? TaskAssignmentCollection { get; init; }

        /// <summary>
        /// Whether the task has been completed
        /// </summary>
        [JsonPropertyName("is_completed")]
        public bool? IsCompleted { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        /// <summary>
        /// When the task object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// Defines which assignees need to complete this task before the task
        /// is considered completed.
        /// 
        /// * `all_assignees` requires all assignees to review or
        /// approve the the task in order for it to be considered completed.
        /// * `any_assignee` accepts any one assignee to review or
        /// approve the the task in order for it to be considered completed.
        /// </summary>
        [JsonPropertyName("completion_rule")]
        public TaskCompletionRuleField? CompletionRule { get; init; }

        public Task() {
            
        }
    }
}