using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class UpdateShieldInformationBarrierSegmentByIdRequestBody {
        [JsonInclude]
        [JsonPropertyName("_isdescriptionSet")]
        protected bool _isDescriptionSet { get; set; }

        protected string? _description { get; set; }

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
        public string? Description { get => _description; init { _description = value; _isDescriptionSet = true; } }

        public UpdateShieldInformationBarrierSegmentByIdRequestBody() {
            
        }
    }
}