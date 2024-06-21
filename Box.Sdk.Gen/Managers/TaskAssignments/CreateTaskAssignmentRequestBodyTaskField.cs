using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

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
        [JsonConverter(typeof(StringEnumConverter<CreateTaskAssignmentRequestBodyTaskTypeField>))]
        public StringEnum<CreateTaskAssignmentRequestBodyTaskTypeField> Type { get; }

        public CreateTaskAssignmentRequestBodyTaskField(string id, CreateTaskAssignmentRequestBodyTaskTypeField type = CreateTaskAssignmentRequestBodyTaskTypeField.Task) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal CreateTaskAssignmentRequestBodyTaskField(string id, StringEnum<CreateTaskAssignmentRequestBodyTaskTypeField> type) {
            Id = id;
            Type = CreateTaskAssignmentRequestBodyTaskTypeField.Task;
        }
    }
}