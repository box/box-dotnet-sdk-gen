using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceByIdRequestBodyArg {
        [JsonPropertyName("status")]
        public UpdateTermOfServiceByIdRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("text")]
        public string Text { get; }

        public UpdateTermOfServiceByIdRequestBodyArg(UpdateTermOfServiceByIdRequestBodyArgStatusField status, string text) {
            Status = status;
            Text = text;
        }
    }
}