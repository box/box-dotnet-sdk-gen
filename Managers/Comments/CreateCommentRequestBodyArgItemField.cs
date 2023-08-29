using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCommentRequestBodyArgItemField {
        /// <summary>
        /// The ID of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the item that this comment will be placed on.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCommentRequestBodyArgItemFieldTypeField Type { get; set; }

        public CreateCommentRequestBodyArgItemField(string id, CreateCommentRequestBodyArgItemFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}