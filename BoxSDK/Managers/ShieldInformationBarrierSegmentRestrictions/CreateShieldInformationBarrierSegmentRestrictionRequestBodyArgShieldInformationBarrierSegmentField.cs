using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField {
        /// <summary>
        /// The ID reference of the requesting
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the shield barrier segment for this member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentFieldTypeField? Type { get; set; } = default;

        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField() {
            
        }
    }
}