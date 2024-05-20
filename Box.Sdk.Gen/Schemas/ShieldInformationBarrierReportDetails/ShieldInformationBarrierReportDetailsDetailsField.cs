using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportDetailsDetailsField {
        /// <summary>
        /// Folder ID for locating this report
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; init; }

        public ShieldInformationBarrierReportDetailsDetailsField() {
            
        }
    }
}