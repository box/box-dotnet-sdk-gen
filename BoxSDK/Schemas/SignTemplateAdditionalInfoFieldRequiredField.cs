using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateAdditionalInfoFieldRequiredField {
        /// <summary>
        /// Required signer fields.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<IReadOnlyList<SignTemplateAdditionalInfoFieldRequiredFieldSignersField>>? Signers { get; set; } = default;

        public SignTemplateAdditionalInfoFieldRequiredField() {
            
        }
    }
}