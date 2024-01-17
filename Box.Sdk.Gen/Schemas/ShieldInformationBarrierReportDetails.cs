using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportDetails {
        [JsonPropertyName("details")]
        public ShieldInformationBarrierReportDetailsDetailsField? Details { get; set; } = default;

        public ShieldInformationBarrierReportDetails() {
            
        }
    }
}