using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceRequestBodyArg {
        [JsonPropertyName("status")]
        public CreateTermOfServiceRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("tos_type")]
        public CreateTermOfServiceRequestBodyArgTosTypeField TosType { get; }

        [JsonPropertyName("text")]
        public string Text { get; }

        public CreateTermOfServiceRequestBodyArg(CreateTermOfServiceRequestBodyArgStatusField status, CreateTermOfServiceRequestBodyArgTosTypeField tosType, string text) {
            Status = status;
            TosType = tosType;
            Text = text;
        }
    }
}