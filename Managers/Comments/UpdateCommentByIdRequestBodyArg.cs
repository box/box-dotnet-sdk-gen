using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateCommentByIdRequestBodyArg {
        [JsonPropertyName("message")]
        public string Message { get; }

        public UpdateCommentByIdRequestBodyArg(string message) {
            Message = message;
        }
    }
}