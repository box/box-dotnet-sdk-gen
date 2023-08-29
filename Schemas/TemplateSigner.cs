using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSigner {
        [JsonPropertyName("inputs")]
        public IReadOnlyList<TemplateSignerInput>? Inputs { get; set; } = default;

        /// <summary>
        /// Email address of the signer
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; } = default;

        /// <summary>
        /// Defines the role of the signer in the signature request. A role of
        /// `signer` needs to sign the document, a role `approver`
        /// approves the document and
        /// a `final_copy_reader` role only
        /// receives the final signed document and signing log.
        /// </summary>
        [JsonPropertyName("role")]
        public TemplateSignerRoleField? Role { get; set; } = default;

        /// <summary>
        /// Used in combination with an embed URL for a sender.
        /// After the sender signs, they will be
        /// redirected to the next `in_person` signer.
        /// </summary>
        [JsonPropertyName("is_in_person")]
        public bool? IsInPerson { get; set; } = default;

        /// <summary>
        /// Order of the signer
        /// </summary>
        [JsonPropertyName("order")]
        public int? Order { get; set; } = default;

        public TemplateSigner() {
            
        }
    }
}