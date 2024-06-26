using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBodyFolderField {
        /// <summary>
        /// The type of the folder object
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StartWorkflowRequestBodyFolderTypeField>))]
        public StringEnum<StartWorkflowRequestBodyFolderTypeField>? Type { get; init; }

        /// <summary>
        /// The id of the folder
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public StartWorkflowRequestBodyFolderField() {
            
        }
    }
}