using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBodyFilesField {
        /// <summary>
        /// The type of the file object
        /// </summary>
        [JsonPropertyName("type")]
        public StartWorkflowRequestBodyFilesTypeField? Type { get; init; }

        /// <summary>
        /// The id of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public StartWorkflowRequestBodyFilesField() {
            
        }
    }
}