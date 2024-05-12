using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFull : Workflow {
        /// <summary>
        /// The date and time when the workflow was created on Box
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// The date and time when the workflow was last updated on Box
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserBase? ModifiedBy { get; set; } = default;

        public WorkflowFull() {
            
        }
    }
}