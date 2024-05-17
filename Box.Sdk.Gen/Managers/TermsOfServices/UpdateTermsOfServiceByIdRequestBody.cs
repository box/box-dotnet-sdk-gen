using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateTermsOfServiceByIdRequestBody {
        /// <summary>
        /// Whether this terms of service is active.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateTermsOfServiceByIdRequestBodyStatusField Status { get; }

        /// <summary>
        /// The terms of service text to display to users.
        /// 
        /// The text can be set to empty if the `status` is set to `disabled`.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; }

        public UpdateTermsOfServiceByIdRequestBody(UpdateTermsOfServiceByIdRequestBodyStatusField status, string text) {
            Status = status;
            Text = text;
        }
    }
}