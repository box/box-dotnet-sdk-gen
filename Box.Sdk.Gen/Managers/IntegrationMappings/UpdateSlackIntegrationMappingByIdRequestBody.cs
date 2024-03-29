using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateSlackIntegrationMappingByIdRequestBody {
        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack? BoxItem { get; set; } = default;

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; set; } = default;

        public UpdateSlackIntegrationMappingByIdRequestBody() {
            
        }
    }
}