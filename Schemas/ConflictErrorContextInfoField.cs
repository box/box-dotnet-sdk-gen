using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ConflictErrorContextInfoField {
        [JsonPropertyName("conflicts")]
        public IReadOnlyList<FileConflict> Conflicts { get; }

        public ConflictErrorContextInfoField(IReadOnlyList<FileConflict> conflicts) {
            Conflicts = conflicts;
        }
    }
}