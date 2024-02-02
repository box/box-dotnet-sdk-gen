using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestCreateSigner {
        /// <summary>
        /// Email address of the signer.
        /// The email address of the signer is required when making signature requests, except when using templates that are configured to include emails.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; } = default;

        /// <summary>
        /// Defines the role of the signer in the sign request. A `signer`
        /// must sign the document and an `approver` must approve the document. A
        /// `final_copy_reader` only receives the final signed document and signing
        /// log.
        /// </summary>
        [JsonPropertyName("role")]
        public SignRequestCreateSignerRoleField? Role { get; set; } = default;

        /// <summary>
        /// Used in combination with an embed URL for a sender. After the
        /// sender signs, they are redirected to the next `in_person` signer.
        /// </summary>
        [JsonPropertyName("is_in_person")]
        public bool? IsInPerson { get; set; } = default;

        /// <summary>
        /// Order of the signer
        /// </summary>
        [JsonPropertyName("order")]
        public long? Order { get; set; } = default;

        /// <summary>
        /// User ID for the signer in an external application responsible
        /// for authentication when accessing the embed URL.
        /// </summary>
        [JsonPropertyName("embed_url_external_user_id")]
        public string? EmbedUrlExternalUserId { get; set; } = default;

        /// <summary>
        /// The URL that a signer will be redirected
        /// to after signing a document. Defining this URL
        /// overrides default or global redirect URL
        /// settings for a specific signer.
        /// If no declined redirect URL is specified,
        /// this URL will be used for decline actions as well.
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; } = default;

        /// <summary>
        /// The URL that a signer will be redirect
        /// to after declining to sign a document.
        /// Defining this URL overrides default or global
        /// declined redirect URL settings for a specific signer.
        /// </summary>
        [JsonPropertyName("declined_redirect_url")]
        public string? DeclinedRedirectUrl { get; set; } = default;

        /// <summary>
        /// If set to true, signer will need to login to a Box account
        /// before signing the request. If the signer does not have
        /// an existing account, they will have an option to create
        /// a free Box account.
        /// </summary>
        [JsonPropertyName("login_required")]
        public bool? LoginRequired { get; set; } = default;

        /// <summary>
        /// If set, this phone number is be used to verify the signer
        /// via two factor authentication before they are able to sign the document.
        /// </summary>
        [JsonPropertyName("verification_phone_number")]
        public string? VerificationPhoneNumber { get; set; } = default;

        /// <summary>
        /// If set, the signer is required to enter the password before they are able
        /// to sign a document. This field is write only.
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; } = default;

        /// <summary>
        /// If set, signers who have the same value will be assigned to the same input and to the same signer group.
        /// A signer group is not a Box Group. It is an entity that belongs to a Sign Request and can only be
        /// used/accessed within this Sign Request. A signer group is expected to have more than one signer.
        /// If the provided value is only used for one signer, this value will be ignored and request will be handled
        /// as it was intended for an individual signer. The value provided can be any string and only used to
        /// determine which signers belongs to same group. A successful response will provide a generated UUID value
        /// instead for signers in the same signer group.
        /// </summary>
        [JsonPropertyName("signer_group_id")]
        public string? SignerGroupId { get; set; } = default;

        public SignRequestCreateSigner() {
            
        }
    }
}