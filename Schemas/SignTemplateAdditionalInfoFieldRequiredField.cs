using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateAdditionalInfoFieldRequiredField {
        [JsonPropertyName("signers")]
        public IReadOnlyList<IReadOnlyList<SignTemplateAdditionalInfoFieldRequiredFieldSignersField>> Signers { get; }

        public SignTemplateAdditionalInfoFieldRequiredField(IReadOnlyList<IReadOnlyList<SignTemplateAdditionalInfoFieldRequiredFieldSignersField>> signers) {
            Signers = signers;
        }
    }
}