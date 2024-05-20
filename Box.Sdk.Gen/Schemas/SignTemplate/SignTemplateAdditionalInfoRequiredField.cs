using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateAdditionalInfoRequiredField {
        /// <summary>
        /// Required signer fields.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<IReadOnlyList<SignTemplateAdditionalInfoRequiredSignersField>>? Signers { get; init; }

        public SignTemplateAdditionalInfoRequiredField() {
            
        }
    }
}