using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArg {
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgTypeField Type { get; }

        [JsonPropertyName("flow")]
        public CreateWorkflowStartRequestBodyArgFlowField Flow { get; }

        [JsonPropertyName("files")]
        public IReadOnlyList<CreateWorkflowStartRequestBodyArgFilesField> Files { get; }

        [JsonPropertyName("folder")]
        public CreateWorkflowStartRequestBodyArgFolderField Folder { get; }

        [JsonPropertyName("outcomes")]
        public IReadOnlyList<CreateWorkflowStartRequestBodyArgOutcomesField> Outcomes { get; }

        public CreateWorkflowStartRequestBodyArg(CreateWorkflowStartRequestBodyArgTypeField type, CreateWorkflowStartRequestBodyArgFlowField flow, IReadOnlyList<CreateWorkflowStartRequestBodyArgFilesField> files, CreateWorkflowStartRequestBodyArgFolderField folder, IReadOnlyList<CreateWorkflowStartRequestBodyArgOutcomesField> outcomes) {
            Type = type;
            Flow = flow;
            Files = files;
            Folder = folder;
            Outcomes = outcomes;
        }
    }
}