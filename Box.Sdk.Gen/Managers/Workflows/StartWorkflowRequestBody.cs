using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBody {
        /// <summary>
        /// The type of the parameters object
        /// </summary>
        [JsonPropertyName("type")]
        public StartWorkflowRequestBodyTypeField? Type { get; set; } = default;

        /// <summary>
        /// The flow that will be triggered
        /// </summary>
        [JsonPropertyName("flow")]
        public StartWorkflowRequestBodyFlowField Flow { get; set; }

        /// <summary>
        /// The array of files for which the workflow should start. All files
        /// must be in the workflow's configured folder.
        /// </summary>
        [JsonPropertyName("files")]
        public IReadOnlyList<StartWorkflowRequestBodyFilesField> Files { get; set; }

        /// <summary>
        /// The folder object for which the workflow is configured.
        /// </summary>
        [JsonPropertyName("folder")]
        public StartWorkflowRequestBodyFolderField Folder { get; set; }

        /// <summary>
        /// A list of outcomes required to be configured at start time.
        /// </summary>
        [JsonPropertyName("outcomes")]
        public IReadOnlyList<StartWorkflowRequestBodyOutcomesField>? Outcomes { get; set; } = default;

        public StartWorkflowRequestBody(StartWorkflowRequestBodyFlowField flow, IReadOnlyList<StartWorkflowRequestBodyFilesField> files, StartWorkflowRequestBodyFolderField folder) {
            Flow = flow;
            Files = files;
            Folder = folder;
        }
    }
}