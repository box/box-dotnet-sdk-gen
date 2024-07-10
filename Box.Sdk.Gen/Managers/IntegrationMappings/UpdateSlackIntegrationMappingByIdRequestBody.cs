using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class UpdateSlackIntegrationMappingByIdRequestBody {
        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack? BoxItem { get; init; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions? Options { get; init; }

        public UpdateSlackIntegrationMappingByIdRequestBody() {
            
        }
    }
}