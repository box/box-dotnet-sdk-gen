using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierRequestBody {
        /// <summary>
        /// The `type` and `id` of enterprise this barrier is under.
        /// </summary>
        [JsonPropertyName("enterprise")]
        public EnterpriseBase Enterprise { get; set; }

        public CreateShieldInformationBarrierRequestBody(EnterpriseBase enterprise) {
            Enterprise = enterprise;
        }
    }
}