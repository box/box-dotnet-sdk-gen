using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBody {
        /// <summary>
        /// The task to assign to a user.
        /// </summary>
        [JsonPropertyName("task")]
        public CreateTaskAssignmentRequestBodyTaskField Task { get; set; }

        /// <summary>
        /// The user to assign the task to.
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateTaskAssignmentRequestBodyAssignToField AssignTo { get; set; }

        public CreateTaskAssignmentRequestBody(CreateTaskAssignmentRequestBodyTaskField task, CreateTaskAssignmentRequestBodyAssignToField assignTo) {
            Task = task;
            AssignTo = assignTo;
        }
    }
}