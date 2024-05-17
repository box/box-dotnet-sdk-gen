using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateTaskAssignmentRequestBodyTaskField {
        /// <summary>
        /// The ID of the task
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the item to assign.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTaskAssignmentRequestBodyTaskTypeField Type { get; }

        public CreateTaskAssignmentRequestBodyTaskField(string id, CreateTaskAssignmentRequestBodyTaskTypeField type = CreateTaskAssignmentRequestBodyTaskTypeField.Task) {
            Id = id;
            Type = type;
        }
    }
}