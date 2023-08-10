using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierBaseTypeField Type { get; }

        public ShieldInformationBarrierBase(string id, ShieldInformationBarrierBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}