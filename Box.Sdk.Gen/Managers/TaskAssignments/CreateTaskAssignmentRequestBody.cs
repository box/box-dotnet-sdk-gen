using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateTaskAssignmentRequestBody {
        /// <summary>
        /// The task to assign to a user.
        /// </summary>
        [JsonPropertyName("task")]
        public CreateTaskAssignmentRequestBodyTaskField Task { get; }

        /// <summary>
        /// The user to assign the task to.
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateTaskAssignmentRequestBodyAssignToField AssignTo { get; }

        public CreateTaskAssignmentRequestBody(CreateTaskAssignmentRequestBodyTaskField task, CreateTaskAssignmentRequestBodyAssignToField assignTo) {
            Task = task;
            AssignTo = assignTo;
        }
    }
}