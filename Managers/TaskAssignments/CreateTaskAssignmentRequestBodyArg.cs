using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBodyArg {
        /// <summary>
        /// The task to assign to a user.
        /// </summary>
        [JsonPropertyName("task")]
        public CreateTaskAssignmentRequestBodyArgTaskField Task { get; set; }

        /// <summary>
        /// The user to assign the task to.
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateTaskAssignmentRequestBodyArgAssignToField AssignTo { get; set; }

        public CreateTaskAssignmentRequestBodyArg(CreateTaskAssignmentRequestBodyArgTaskField task, CreateTaskAssignmentRequestBodyArgAssignToField assignTo) {
            Task = task;
            AssignTo = assignTo;
        }
    }
}