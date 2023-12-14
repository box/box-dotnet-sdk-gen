using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSignerSignerDecisionField {
        /// <summary>
        /// Type of decision made by the signer
        /// </summary>
        [JsonPropertyName("type")]
        public SignRequestSignerSignerDecisionTypeField? Type { get; set; } = default;

        /// <summary>
        /// Date and Time that the decision was made
        /// </summary>
        [JsonPropertyName("finalized_at")]
        public string? FinalizedAt { get; set; } = default;

        /// <summary>
        /// Additional info about the decision, such as the decline reason from the signer
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string? AdditionalInfo { get; set; } = default;

        public SignRequestSignerSignerDecisionField() {
            
        }
    }
}