using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ShieldInformationBarrierReportDetailsDetailsField {
        [JsonPropertyName("folder_id")]
        public string FolderId { get; }

        public ShieldInformationBarrierReportDetailsDetailsField(string folderId) {
            FolderId = folderId;
        }
    }
}