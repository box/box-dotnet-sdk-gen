using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestCreateSigner {
        [JsonPropertyName("email")]
        public string Email { get; }

        [JsonPropertyName("role")]
        public SignRequestCreateSignerRoleField Role { get; }

        [JsonPropertyName("is_in_person")]
        public bool? IsInPerson { get; }

        [JsonPropertyName("order")]
        public int? Order { get; }

        [JsonPropertyName("embed_url_external_user_id")]
        public string EmbedUrlExternalUserId { get; }

        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; }

        [JsonPropertyName("declined_redirect_url")]
        public string DeclinedRedirectUrl { get; }

        [JsonPropertyName("login_required")]
        public bool? LoginRequired { get; }

        [JsonPropertyName("verification_phone_number")]
        public string VerificationPhoneNumber { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        public SignRequestCreateSigner(string email, SignRequestCreateSignerRoleField role, bool? isInPerson, int? order, string embedUrlExternalUserId, string redirectUrl, string declinedRedirectUrl, bool? loginRequired, string verificationPhoneNumber, string password) {
            Email = email;
            Role = role;
            IsInPerson = isInPerson;
            Order = order;
            EmbedUrlExternalUserId = embedUrlExternalUserId;
            RedirectUrl = redirectUrl;
            DeclinedRedirectUrl = declinedRedirectUrl;
            LoginRequired = loginRequired;
            VerificationPhoneNumber = verificationPhoneNumber;
            Password = password;
        }
    }
}