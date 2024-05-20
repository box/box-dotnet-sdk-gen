using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateTermsOfServiceStatusForUserRequestBodyTosField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTermsOfServiceStatusForUserRequestBodyTosTypeField Type { get; }

        /// <summary>
        /// The ID of terms of service
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateTermsOfServiceStatusForUserRequestBodyTosField(string id, CreateTermsOfServiceStatusForUserRequestBodyTosTypeField type = CreateTermsOfServiceStatusForUserRequestBodyTosTypeField.TermsOfService) {
            Type = type;
            Id = id;
        }
    }
}