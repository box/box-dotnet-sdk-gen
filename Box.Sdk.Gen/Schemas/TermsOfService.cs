using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfService : TermsOfServiceBase {
        /// <summary>
        /// Whether these terms are enabled or not
        /// </summary>
        [JsonPropertyName("status")]
        public TermsOfServiceStatusField? Status { get; set; } = default;

        [JsonPropertyName("enterprise")]
        public TermsOfServiceEnterpriseField? Enterprise { get; set; } = default;

        /// <summary>
        /// Whether to apply these terms to managed users or external users
        /// </summary>
        [JsonPropertyName("tos_type")]
        public TermsOfServiceTosTypeField? TosType { get; set; } = default;

        /// <summary>
        /// The text for your terms and conditions. This text could be
        /// empty if the `status` is set to `disabled`.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; } = default;

        /// <summary>
        /// When the legal item was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the legal item was modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        public TermsOfService(string id, TermsOfServiceBaseTypeField type) : base(id, type) {
            
        }
    }
}