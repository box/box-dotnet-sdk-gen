using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskAssignmentRequestBodyArgTaskField {
        /// <summary>
        /// The ID of the task
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the item to assign.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTaskAssignmentRequestBodyArgTaskFieldTypeField Type { get; set; }

        public CreateTaskAssignmentRequestBodyArgTaskField(string id, CreateTaskAssignmentRequestBodyArgTaskFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}