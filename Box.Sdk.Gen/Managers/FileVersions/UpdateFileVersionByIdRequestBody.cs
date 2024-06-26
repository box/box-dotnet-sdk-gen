using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileVersionByIdRequestBody {
        /// <summary>
        /// Set this to `null` to clear
        /// the date and restore the file.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; init; }

        public UpdateFileVersionByIdRequestBody() {
            
        }
    }
}