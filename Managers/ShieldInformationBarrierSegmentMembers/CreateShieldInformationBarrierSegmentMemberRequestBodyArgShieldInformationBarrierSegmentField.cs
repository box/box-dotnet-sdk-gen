using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentFieldTypeField Type { get; }

        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField(string id, CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentFieldTypeField type) {
            Id = id;
            Type = type;
        }
    }
}