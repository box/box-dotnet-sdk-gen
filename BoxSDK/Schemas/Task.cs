using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Task {
        /// <summary>
        /// The unique identifier for this task
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `task`
        /// </summary>
        [JsonPropertyName("type")]
        public TaskTypeField? Type { get; set; } = default;

        [JsonPropertyName("item")]
        public FileMini? Item { get; set; } = default;

        /// <summary>
        /// When the task is due
        /// </summary>
        [JsonPropertyName("due_at")]
        public string? DueAt { get; set; } = default;

        /// <summary>
        /// The type of task the task assignee will be prompted to
        /// perform.
        /// </summary>
        [JsonPropertyName("action")]
        public TaskActionField? Action { get; set; } = default;

        /// <summary>
        /// A message that will be included with the task
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        [JsonPropertyName("task_assignment_collection")]
        public TaskAssignments? TaskAssignmentCollection { get; set; } = default;

        /// <summary>
        /// Whether the task has been completed
        /// </summary>
        [JsonPropertyName("is_completed")]
        public bool? IsCompleted { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// When the task object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

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
        public TaskCompletionRuleField? CompletionRule { get; set; } = default;

        public Task() {
            
        }
    }
}