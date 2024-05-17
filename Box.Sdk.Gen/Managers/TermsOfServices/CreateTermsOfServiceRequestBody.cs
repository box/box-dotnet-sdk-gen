using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateTermsOfServiceRequestBody {
        /// <summary>
        /// Whether this terms of service is active.
        /// </summary>
        [JsonPropertyName("status")]
        public CreateTermsOfServiceRequestBodyStatusField Status { get; }

        /// <summary>
        /// The type of user to set the terms of
        /// service for.
        /// </summary>
        [JsonPropertyName("tos_type")]
        public CreateTermsOfServiceRequestBodyTosTypeField? TosType { get; init; }

        /// <summary>
        /// The terms of service text to display to users.
        /// 
        /// The text can be set to empty if the `status` is set to `disabled`.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; }

        public CreateTermsOfServiceRequestBody(CreateTermsOfServiceRequestBodyStatusField status, string text) {
            Status = status;
            Text = text;
        }
    }
}