using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportBase {
        /// <summary>
        /// The unique identifier for the shield information barrier report
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield information barrier report
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierReportBaseTypeField? Type { get; set; } = default;

        public ShieldInformationBarrierReportBase() {
            
        }
    }
}