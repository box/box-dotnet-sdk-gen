using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TaskAssignment {
        /// <summary>
        /// The unique identifier for this task assignment
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `task_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public TaskAssignmentTypeField? Type { get; set; } = default;

        [JsonPropertyName("item")]
        public FileMini? Item { get; set; } = default;

        [JsonPropertyName("assigned_to")]
        public UserMini? AssignedTo { get; set; } = default;

        /// <summary>
        /// A message that will is included with the task
        /// assignment. This is visible to the assigned user in the web and mobile
        /// UI.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        /// <summary>
        /// The date at which this task assignment was
        /// completed. This will be `null` if the task is not completed yet.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; } = default;

        /// <summary>
        /// The date at which this task was assigned to the user.
        /// </summary>
        [JsonPropertyName("assigned_at")]
        public string? AssignedAt { get; set; } = default;

        /// <summary>
        /// The date at which the assigned user was reminded of this task
        /// assignment.
        /// </summary>
        [JsonPropertyName("reminded_at")]
        public string? RemindedAt { get; set; } = default;

        /// <summary>
        /// The current state of the assignment. The available states depend on
        /// the `action` value of the task object.
        /// </summary>
        [JsonPropertyName("resolution_state")]
        public TaskAssignmentResolutionStateField? ResolutionState { get; set; } = default;

        [JsonPropertyName("assigned_by")]
        public UserMini? AssignedBy { get; set; } = default;

        public TaskAssignment() {
            
        }
    }
}