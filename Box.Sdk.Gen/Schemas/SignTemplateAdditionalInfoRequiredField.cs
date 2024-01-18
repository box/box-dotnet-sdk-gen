using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateAdditionalInfoRequiredField {
        /// <summary>
        /// Required signer fields.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<IReadOnlyList<SignTemplateAdditionalInfoRequiredSignersField>>? Signers { get; set; } = default;

        public SignTemplateAdditionalInfoRequiredField() {
            
        }
    }
}