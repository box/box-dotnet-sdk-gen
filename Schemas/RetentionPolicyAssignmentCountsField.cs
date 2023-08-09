using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentCountsField {
        [JsonPropertyName("enterprise")]
        public int? Enterprise { get; }

        [JsonPropertyName("folder")]
        public int? Folder { get; }

        [JsonPropertyName("metadata_template")]
        public int? MetadataTemplate { get; }

        public RetentionPolicyAssignmentCountsField(int? enterprise, int? folder, int? metadataTemplate) {
            Enterprise = enterprise;
            Folder = folder;
            MetadataTemplate = metadataTemplate;
        }
    }
}