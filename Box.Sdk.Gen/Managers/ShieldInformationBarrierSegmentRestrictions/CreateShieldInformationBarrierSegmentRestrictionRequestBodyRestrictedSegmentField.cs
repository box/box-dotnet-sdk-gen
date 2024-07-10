using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField {
        /// <summary>
        /// The ID reference of the restricted
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the restricted shield
        /// information barrier segment.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentTypeField>))]
        public StringEnum<CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentTypeField>? Type { get; init; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField() {
            
        }
    }
}