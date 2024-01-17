using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
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