using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TemplateSigner {
        [JsonPropertyName("inputs")]
        public IReadOnlyList<TemplateSignerInput>? Inputs { get; init; }

        /// <summary>
        /// Email address of the signer
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; init; }

        /// <summary>
        /// Defines the role of the signer in the signature request. A role of
        /// `signer` needs to sign the document, a role `approver`
        /// approves the document and
        /// a `final_copy_reader` role only
        /// receives the final signed document and signing log.
        /// </summary>
        [JsonPropertyName("role")]
        [JsonConverter(typeof(StringEnumConverter<TemplateSignerRoleField>))]
        public StringEnum<TemplateSignerRoleField>? Role { get; init; }

        /// <summary>
        /// Used in combination with an embed URL for a sender.
        /// After the sender signs, they will be
        /// redirected to the next `in_person` signer.
        /// </summary>
        [JsonPropertyName("is_in_person")]
        public bool? IsInPerson { get; init; }

        /// <summary>
        /// Order of the signer
        /// </summary>
        [JsonPropertyName("order")]
        public long? Order { get; init; }

        /// <summary>
        /// If provided, this value points signers that are assigned the same inputs and belongs to same signer group.
        /// A signer group is not a Box Group. It is an entity that belongs to the template itself and can only be used
        /// within Box Sign requests created from it.
        /// </summary>
        [JsonPropertyName("signer_group_id")]
        public string? SignerGroupId { get; init; }

        public TemplateSigner() {
            
        }
    }
}