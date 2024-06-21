using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServiceBase {
        /// <summary>
        /// The unique identifier for this terms of service.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `terms_of_service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TermsOfServiceBaseTypeField>))]
        public StringEnum<TermsOfServiceBaseTypeField> Type { get; }

        public TermsOfServiceBase(string id, TermsOfServiceBaseTypeField type = TermsOfServiceBaseTypeField.TermsOfService) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal TermsOfServiceBase(string id, StringEnum<TermsOfServiceBaseTypeField> type) {
            Id = id;
            Type = TermsOfServiceBaseTypeField.TermsOfService;
        }
    }
}