using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicyMini {
        /// <summary>
        /// The unique identifier for this legal hold policy
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `legal_hold_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public LegalHoldPolicyMiniTypeField? Type { get; set; } = default;

        public LegalHoldPolicyMini() {
            
        }
    }
}