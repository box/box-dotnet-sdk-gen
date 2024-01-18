using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class ConflictErrorContextInfoField {
        /// <summary>
        /// A list of the file conflicts that caused this error.
        /// </summary>
        [JsonPropertyName("conflicts")]
        public IReadOnlyList<FileConflict>? Conflicts { get; set; } = default;

        public ConflictErrorContextInfoField() {
            
        }
    }
}