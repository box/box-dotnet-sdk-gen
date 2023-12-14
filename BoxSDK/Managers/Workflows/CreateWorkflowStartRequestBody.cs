using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBody {
        /// <summary>
        /// The type of the parameters object
        /// </summary>
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyTypeField? Type { get; set; } = default;

        /// <summary>
        /// The flow that will be triggered
        /// </summary>
        [JsonPropertyName("flow")]
        public CreateWorkflowStartRequestBodyFlowField Flow { get; set; }

        /// <summary>
        /// The array of files for which the workflow should start. All files
        /// must be in the workflow's configured folder.
        /// </summary>
        [JsonPropertyName("files")]
        public IReadOnlyList<CreateWorkflowStartRequestBodyFilesField> Files { get; set; }

        /// <summary>
        /// The folder object for which the workflow is configured.
        /// </summary>
        [JsonPropertyName("folder")]
        public CreateWorkflowStartRequestBodyFolderField Folder { get; set; }

        /// <summary>
        /// A list of outcomes required to be configured at start time.
        /// </summary>
        [JsonPropertyName("outcomes")]
        public IReadOnlyList<CreateWorkflowStartRequestBodyOutcomesField>? Outcomes { get; set; } = default;

        public CreateWorkflowStartRequestBody(CreateWorkflowStartRequestBodyFlowField flow, IReadOnlyList<CreateWorkflowStartRequestBodyFilesField> files, CreateWorkflowStartRequestBodyFolderField folder) {
            Flow = flow;
            Files = files;
            Folder = folder;
        }
    }
}