using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class LegalHoldPolicyAssignmentCountsField {
        /// <summary>
        /// The number of users this policy is applied to
        /// </summary>
        [JsonPropertyName("user")]
        public long? User { get; set; } = default;

        /// <summary>
        /// The number of folders this policy is applied to
        /// </summary>
        [JsonPropertyName("folder")]
        public long? Folder { get; set; } = default;

        /// <summary>
        /// The number of files this policy is applied to
        /// </summary>
        [JsonPropertyName("file")]
        public long? File { get; set; } = default;

        /// <summary>
        /// The number of file versions this policy is applied to
        /// </summary>
        [JsonPropertyName("file_version")]
        public long? FileVersion { get; set; } = default;

        public LegalHoldPolicyAssignmentCountsField() {
            
        }
    }
}