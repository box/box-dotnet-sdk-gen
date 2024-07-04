using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateTermsOfServiceStatusForUserRequestBodyTosField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceStatusForUserRequestBodyTosTypeField>))]
        public StringEnum<CreateTermsOfServiceStatusForUserRequestBodyTosTypeField> Type { get; }

        /// <summary>
        /// The ID of terms of service
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateTermsOfServiceStatusForUserRequestBodyTosField(string id, CreateTermsOfServiceStatusForUserRequestBodyTosTypeField type = CreateTermsOfServiceStatusForUserRequestBodyTosTypeField.TermsOfService) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CreateTermsOfServiceStatusForUserRequestBodyTosField(string id, StringEnum<CreateTermsOfServiceStatusForUserRequestBodyTosTypeField> type) {
            Type = CreateTermsOfServiceStatusForUserRequestBodyTosTypeField.TermsOfService;
            Id = id;
        }
    }
}