using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateTermsOfServiceByIdRequestBody {
        /// <summary>
        /// Whether this terms of service is active.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringEnumConverter<UpdateTermsOfServiceByIdRequestBodyStatusField>))]
        public StringEnum<UpdateTermsOfServiceByIdRequestBodyStatusField> Status { get; }

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
        
        [JsonConstructorAttribute]
        internal UpdateTermsOfServiceByIdRequestBody(StringEnum<UpdateTermsOfServiceByIdRequestBodyStatusField> status, string text) {
            Status = status;
            Text = text;
        }
    }
}