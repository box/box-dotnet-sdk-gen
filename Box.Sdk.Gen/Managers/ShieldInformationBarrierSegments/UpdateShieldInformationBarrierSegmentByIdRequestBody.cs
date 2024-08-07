using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class UpdateShieldInformationBarrierSegmentByIdRequestBody {
        /// <summary>
        /// The updated name for the shield information barrier segment.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The updated description for
        /// the shield information barrier segment.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        public UpdateShieldInformationBarrierSegmentByIdRequestBody() {
            
        }
    }
}