using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileVersionByIdRequestBody {
        [JsonInclude]
        [JsonPropertyName("_istrashed_atSet")]
        protected bool _isTrashedAtSet { get; set; }

        protected string? _trashedAt { get; set; }

        /// <summary>
        /// Set this to `null` to clear
        /// the date and restore the file.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get => _trashedAt; init { _trashedAt = value; _isTrashedAtSet = true; } }

        public UpdateFileVersionByIdRequestBody() {
            
        }
    }
}