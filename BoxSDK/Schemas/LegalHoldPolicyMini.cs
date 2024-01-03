using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class LegalHoldPolicyMini {
        /// <summary>
        /// The unique identifier for this legal hold policy
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `legal_hold_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public LegalHoldPolicyMiniTypeField Type { get; set; }

        public LegalHoldPolicyMini(string id, LegalHoldPolicyMiniTypeField type) {
            Id = id;
            Type = type;
        }
    }
}