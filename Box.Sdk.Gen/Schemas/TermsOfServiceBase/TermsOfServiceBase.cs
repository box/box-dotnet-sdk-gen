using Unions;
using System.Text.Json.Serialization;

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
        public TermsOfServiceBaseTypeField Type { get; }

        public TermsOfServiceBase(string id, TermsOfServiceBaseTypeField type = TermsOfServiceBaseTypeField.TermsOfService) {
            Id = id;
            Type = type;
        }
    }
}