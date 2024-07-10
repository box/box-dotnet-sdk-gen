using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateShieldInformationBarrierStatusRequestBody {
        /// <summary>
        /// The ID of the shield information barrier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The desired status for the shield information barrier.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringEnumConverter<UpdateShieldInformationBarrierStatusRequestBodyStatusField>))]
        public StringEnum<UpdateShieldInformationBarrierStatusRequestBodyStatusField> Status { get; }

        public UpdateShieldInformationBarrierStatusRequestBody(string id, UpdateShieldInformationBarrierStatusRequestBodyStatusField status) {
            Id = id;
            Status = status;
        }
        
        [JsonConstructorAttribute]
        internal UpdateShieldInformationBarrierStatusRequestBody(string id, StringEnum<UpdateShieldInformationBarrierStatusRequestBodyStatusField> status) {
            Id = id;
            Status = status;
        }
    }
}