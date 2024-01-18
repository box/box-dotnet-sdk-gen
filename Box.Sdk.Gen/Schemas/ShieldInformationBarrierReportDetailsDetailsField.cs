using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportDetailsDetailsField {
        /// <summary>
        /// Folder ID for locating this report
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; set; } = default;

        public ShieldInformationBarrierReportDetailsDetailsField() {
            
        }
    }
}