using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateCommentRequestBodyItemField {
        /// <summary>
        /// The ID of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the item that this comment will be placed on.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateCommentRequestBodyItemTypeField>))]
        public StringEnum<CreateCommentRequestBodyItemTypeField> Type { get; }

        public CreateCommentRequestBodyItemField(string id, CreateCommentRequestBodyItemTypeField type) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal CreateCommentRequestBodyItemField(string id, StringEnum<CreateCommentRequestBodyItemTypeField> type) {
            Id = id;
            Type = type;
        }
    }
}