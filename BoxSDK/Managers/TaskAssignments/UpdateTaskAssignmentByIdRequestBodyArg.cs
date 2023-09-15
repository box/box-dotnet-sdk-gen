using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTaskAssignmentByIdRequestBodyArg {
        /// <summary>
        /// An optional message by the assignee that can be added to the task.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        /// <summary>
        /// The state of the task assigned to the user.
        /// 
        /// * For a task with an `action` value of `complete` this can be
        /// `incomplete` or `completed`.
        /// * For a task with an `action` of `review` this can be
        /// `incomplete`, `approved`, or `rejected`.
        /// </summary>
        [JsonPropertyName("resolution_state")]
        public UpdateTaskAssignmentByIdRequestBodyArgResolutionStateField? ResolutionState { get; set; } = default;

        public UpdateTaskAssignmentByIdRequestBodyArg() {
            
        }
    }
}