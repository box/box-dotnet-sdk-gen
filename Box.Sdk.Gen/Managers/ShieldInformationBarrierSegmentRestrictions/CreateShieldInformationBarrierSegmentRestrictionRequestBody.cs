using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBody {
        /// <summary>
        /// The type of the shield barrier segment
        /// restriction for this member.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField>))]
        public StringEnum<CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField> Type { get; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; init; }

        /// <summary>
        /// The `type` and `id` of the requested
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        /// <summary>
        /// The `type` and `id` of the restricted
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("restricted_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField RestrictedSegment { get; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBody(CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField shieldInformationBarrierSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField restrictedSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField type = CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField.ShieldInformationBarrierSegmentRestriction) {
            Type = type;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
        
        [JsonConstructorAttribute]
        internal CreateShieldInformationBarrierSegmentRestrictionRequestBody(CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField shieldInformationBarrierSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField restrictedSegment, StringEnum<CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField> type) {
            Type = CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField.ShieldInformationBarrierSegmentRestriction;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}