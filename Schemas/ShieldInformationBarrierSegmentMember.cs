using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegmentMember : ShieldInformationBarrierSegmentMemberMini {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("shield_information_barrier_segment")]
        public ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        [JsonPropertyName("updated_by")]
        public UserBase UpdatedBy { get; }

        public ShieldInformationBarrierSegmentMember(string id, ShieldInformationBarrierSegmentMemberBaseTypeField type, UserBase user, ShieldInformationBarrierBase shieldInformationBarrier, ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentField shieldInformationBarrierSegment, string createdAt, UserBase createdBy, string updatedAt, UserBase updatedBy) : base(id, type, user) {
            ShieldInformationBarrier = shieldInformationBarrier;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
        }
    }
}