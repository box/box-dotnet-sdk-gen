using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateAdditionalInfoRequiredField {
        /// <summary>
        /// Required signer fields.
        /// </summary>
        [JsonPropertyName("signers")]
        [JsonConverter(typeof(StringEnumNestedListConverter<SignTemplateAdditionalInfoRequiredSignersField>))]
        public IReadOnlyList<IReadOnlyList<StringEnum<SignTemplateAdditionalInfoRequiredSignersField>>> Signers { get; init; }

        public SignTemplateAdditionalInfoRequiredField() {
            
        }
    }
}