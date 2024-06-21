using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateTermsOfServiceStatusForUserRequestBodyUserField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceStatusForUserRequestBodyUserTypeField>))]
        public StringEnum<CreateTermsOfServiceStatusForUserRequestBodyUserTypeField> Type { get; }

        /// <summary>
        /// The ID of user
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateTermsOfServiceStatusForUserRequestBodyUserField(string id, CreateTermsOfServiceStatusForUserRequestBodyUserTypeField type = CreateTermsOfServiceStatusForUserRequestBodyUserTypeField.User) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CreateTermsOfServiceStatusForUserRequestBodyUserField(string id, StringEnum<CreateTermsOfServiceStatusForUserRequestBodyUserTypeField> type) {
            Type = CreateTermsOfServiceStatusForUserRequestBodyUserTypeField.User;
            Id = id;
        }
    }
}