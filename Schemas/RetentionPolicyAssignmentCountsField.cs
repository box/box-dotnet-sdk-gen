using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignmentCountsField {
        [JsonPropertyName("enterprise")]
        public long? Enterprise { get; }

        [JsonPropertyName("folder")]
        public long? Folder { get; }

        [JsonPropertyName("metadata_template")]
        public long? MetadataTemplate { get; }

        public RetentionPolicyAssignmentCountsField(long? enterprise, long? folder, long? metadataTemplate) {
            Enterprise = enterprise;
            Folder = folder;
            MetadataTemplate = metadataTemplate;
        }
    }
}