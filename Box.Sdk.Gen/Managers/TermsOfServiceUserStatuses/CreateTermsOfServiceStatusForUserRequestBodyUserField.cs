using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateTermsOfServiceStatusForUserRequestBodyUserField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTermsOfServiceStatusForUserRequestBodyUserTypeField Type { get; }

        /// <summary>
        /// The ID of user
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateTermsOfServiceStatusForUserRequestBodyUserField(string id, CreateTermsOfServiceStatusForUserRequestBodyUserTypeField type = CreateTermsOfServiceStatusForUserRequestBodyUserTypeField.User) {
            Type = type;
            Id = id;
        }
    }
}