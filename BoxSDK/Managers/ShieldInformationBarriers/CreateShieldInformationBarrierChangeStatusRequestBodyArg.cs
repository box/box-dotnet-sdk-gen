using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierChangeStatusRequestBodyArg {
        /// <summary>
        /// The ID of the shield information barrier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The desired status for the shield information barrier.
        /// </summary>
        [JsonPropertyName("status")]
        public CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField Status { get; set; }

        public CreateShieldInformationBarrierChangeStatusRequestBodyArg(string id, CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField status) {
            Id = id;
            Status = status;
        }
    }
}