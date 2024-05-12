using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

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