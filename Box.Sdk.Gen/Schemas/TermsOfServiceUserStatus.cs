using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServiceUserStatus {
        /// <summary>
        /// The unique identifier for this terms of service user status
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `terms_of_service_user_status`
        /// </summary>
        [JsonPropertyName("type")]
        public TermsOfServiceUserStatusTypeField? Type { get; set; } = default;

        [JsonPropertyName("tos")]
        public TermsOfServiceBase? Tos { get; set; } = default;

        [JsonPropertyName("user")]
        public UserMini? User { get; set; } = default;

        /// <summary>
        /// If the user has accepted the terms of services
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; set; } = default;

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

        public TermsOfServiceUserStatus() {
            
        }
    }
}