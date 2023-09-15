using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceByIdRequestBodyArg {
        /// <summary>
        /// Whether this terms of service is active.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateTermOfServiceByIdRequestBodyArgStatusField Status { get; set; }

        /// <summary>
        /// The terms of service text to display to users.
        /// 
        /// The text can be set to empty if the `status` is set to `disabled`.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        public UpdateTermOfServiceByIdRequestBodyArg(UpdateTermOfServiceByIdRequestBodyArgStatusField status, string text) {
            Status = status;
            Text = text;
        }
    }
}