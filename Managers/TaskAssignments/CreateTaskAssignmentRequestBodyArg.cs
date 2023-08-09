using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBodyArg {
        [JsonPropertyName("task")]
        public CreateTaskAssignmentRequestBodyArgTaskField Task { get; }

        [JsonPropertyName("assign_to")]
        public CreateTaskAssignmentRequestBodyArgAssignToField AssignTo { get; }

        public CreateTaskAssignmentRequestBodyArg(CreateTaskAssignmentRequestBodyArgTaskField task, CreateTaskAssignmentRequestBodyArgAssignToField assignTo) {
            Task = task;
            AssignTo = assignTo;
        }
    }
}