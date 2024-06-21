using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateCommentByIdRequestBody {
        /// <summary>
        /// The text of the comment to update
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        public UpdateCommentByIdRequestBody() {
            
        }
    }
}