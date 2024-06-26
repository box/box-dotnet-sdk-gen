using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBodyFilesField {
        /// <summary>
        /// The type of the file object
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StartWorkflowRequestBodyFilesTypeField>))]
        public StringEnum<StartWorkflowRequestBodyFilesTypeField>? Type { get; init; }

        /// <summary>
        /// The id of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public StartWorkflowRequestBodyFilesField() {
            
        }
    }
}