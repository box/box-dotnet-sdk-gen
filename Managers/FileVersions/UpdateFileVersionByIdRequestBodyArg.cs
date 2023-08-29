using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileVersionByIdRequestBodyArg {
        /// <summary>
        /// Set this to `null` to clear
        /// the date and restore the file.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; set; } = default;

        public UpdateFileVersionByIdRequestBodyArg() {
            
        }
    }
}