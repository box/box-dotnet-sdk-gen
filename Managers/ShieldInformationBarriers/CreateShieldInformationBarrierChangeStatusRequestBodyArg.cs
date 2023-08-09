using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierChangeStatusRequestBodyArg {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("status")]
        public CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField Status { get; }

        public CreateShieldInformationBarrierChangeStatusRequestBodyArg(string id, CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField status) {
            Id = id;
            Status = status;
        }
    }
}