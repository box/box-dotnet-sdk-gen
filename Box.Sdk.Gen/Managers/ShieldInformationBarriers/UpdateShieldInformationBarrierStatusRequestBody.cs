using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateShieldInformationBarrierStatusRequestBody {
        /// <summary>
        /// The ID of the shield information barrier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The desired status for the shield information barrier.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateShieldInformationBarrierStatusRequestBodyStatusField Status { get; set; }

        public UpdateShieldInformationBarrierStatusRequestBody(string id, UpdateShieldInformationBarrierStatusRequestBodyStatusField status) {
            Id = id;
            Status = status;
        }
    }
}