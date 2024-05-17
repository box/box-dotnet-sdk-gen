using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServiceUserStatus {
        /// <summary>
        /// The unique identifier for this terms of service user status
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `terms_of_service_user_status`
        /// </summary>
        [JsonPropertyName("type")]
        public TermsOfServiceUserStatusTypeField Type { get; }

        [JsonPropertyName("tos")]
        public TermsOfServiceBase? Tos { get; init; }

        [JsonPropertyName("user")]
        public UserMini? User { get; init; }

        /// <summary>
        /// If the user has accepted the terms of services
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; init; }

        /// <summary>
        /// When the legal item was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the legal item was modified.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        public TermsOfServiceUserStatus(string id, TermsOfServiceUserStatusTypeField type = TermsOfServiceUserStatusTypeField.TermsOfServiceUserStatus) {
            Id = id;
            Type = type;
        }
    }
}