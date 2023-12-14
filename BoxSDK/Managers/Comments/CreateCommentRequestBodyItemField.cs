using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCommentRequestBodyItemField {
        /// <summary>
        /// The ID of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the item that this comment will be placed on.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCommentRequestBodyItemTypeField Type { get; set; }

        public CreateCommentRequestBodyItemField(string id, CreateCommentRequestBodyItemTypeField type) {
            Id = id;
            Type = type;
        }
    }
}