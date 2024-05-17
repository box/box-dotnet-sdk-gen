using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateShieldInformationBarrierRequestBody {
        /// <summary>
        /// The `type` and `id` of enterprise this barrier is under.
        /// </summary>
        [JsonPropertyName("enterprise")]
        public EnterpriseBase Enterprise { get; }

        public CreateShieldInformationBarrierRequestBody(EnterpriseBase enterprise) {
            Enterprise = enterprise;
        }
    }
}