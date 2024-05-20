using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField {
        /// <summary>
        /// The ID reference of the requesting
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield barrier segment for this member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentTypeField? Type { get; init; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField() {
            
        }
    }
}