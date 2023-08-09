using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentMemberBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentMemberBaseTypeField Type { get; }

        public ShieldInformationBarrierSegmentMemberBase(string id, ShieldInformationBarrierSegmentMemberBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}