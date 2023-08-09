using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierReportBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierReportBaseTypeField Type { get; }

        public ShieldInformationBarrierReportBase(string id, ShieldInformationBarrierReportBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}