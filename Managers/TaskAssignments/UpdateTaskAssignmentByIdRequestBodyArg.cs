using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTaskAssignmentByIdRequestBodyArg {
        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("resolution_state")]
        public UpdateTaskAssignmentByIdRequestBodyArgResolutionStateField ResolutionState { get; }

        public UpdateTaskAssignmentByIdRequestBodyArg(string message, UpdateTaskAssignmentByIdRequestBodyArgResolutionStateField resolutionState) {
            Message = message;
            ResolutionState = resolutionState;
        }
    }
}