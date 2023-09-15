using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateCommentByIdRequestBodyArg {
        /// <summary>
        /// The text of the comment to update
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        public UpdateCommentByIdRequestBodyArg() {
            
        }
    }
}