using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Task {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public TaskTypeField Type { get; }

        [JsonPropertyName("item")]
        public FileMini Item { get; }

        [JsonPropertyName("due_at")]
        public string DueAt { get; }

        [JsonPropertyName("action")]
        public TaskActionField Action { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("task_assignment_collection")]
        public TaskAssignments TaskAssignmentCollection { get; }

        [JsonPropertyName("is_completed")]
        public bool? IsCompleted { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("completion_rule")]
        public TaskCompletionRuleField CompletionRule { get; }

        public Task(string id, TaskTypeField type, FileMini item, string dueAt, TaskActionField action, string message, TaskAssignments taskAssignmentCollection, bool? isCompleted, UserMini createdBy, string createdAt, TaskCompletionRuleField completionRule) {
            Id = id;
            Type = type;
            Item = item;
            DueAt = dueAt;
            Action = action;
            Message = message;
            TaskAssignmentCollection = taskAssignmentCollection;
            IsCompleted = isCompleted;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            CompletionRule = completionRule;
        }
    }
}