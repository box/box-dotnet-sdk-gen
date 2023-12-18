using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermsOfServiceStatusForUserRequestBodyTosField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTermsOfServiceStatusForUserRequestBodyTosTypeField Type { get; set; }

        /// <summary>
        /// The ID of terms of service
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateTermsOfServiceStatusForUserRequestBodyTosField(CreateTermsOfServiceStatusForUserRequestBodyTosTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}