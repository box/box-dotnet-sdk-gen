using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileVersionByIdRequestBodyArg {
        [JsonPropertyName("trashed_at")]
        public string TrashedAt { get; }

        public UpdateFileVersionByIdRequestBodyArg(string trashedAt) {
            TrashedAt = trashedAt;
        }
    }
}