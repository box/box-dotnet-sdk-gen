using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateShieldInformationBarrierSegmentByIdRequestBody {
        /// <summary>
        /// The updated name for the shield information barrier segment.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The updated description for
        /// the shield information barrier segment.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        public UpdateShieldInformationBarrierSegmentByIdRequestBody() {
            
        }
    }
}