using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TaskAssignment {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public TaskAssignmentTypeField Type { get; }

        [JsonPropertyName("item")]
        public FileMini Item { get; }

        [JsonPropertyName("assigned_to")]
        public UserMini AssignedTo { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("completed_at")]
        public string CompletedAt { get; }

        [JsonPropertyName("assigned_at")]
        public string AssignedAt { get; }

        [JsonPropertyName("reminded_at")]
        public string RemindedAt { get; }

        [JsonPropertyName("resolution_state")]
        public TaskAssignmentResolutionStateField ResolutionState { get; }

        [JsonPropertyName("assigned_by")]
        public UserMini AssignedBy { get; }

        public TaskAssignment(string id, TaskAssignmentTypeField type, FileMini item, UserMini assignedTo, string message, string completedAt, string assignedAt, string remindedAt, TaskAssignmentResolutionStateField resolutionState, UserMini assignedBy) {
            Id = id;
            Type = type;
            Item = item;
            AssignedTo = assignedTo;
            Message = message;
            CompletedAt = completedAt;
            AssignedAt = assignedAt;
            RemindedAt = remindedAt;
            ResolutionState = resolutionState;
            AssignedBy = assignedBy;
        }
    }
}