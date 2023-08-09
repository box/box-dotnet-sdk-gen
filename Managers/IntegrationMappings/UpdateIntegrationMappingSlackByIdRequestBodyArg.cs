using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateIntegrationMappingSlackByIdRequestBodyArg {
        [JsonPropertyName("box_item")]
        public IntegrationMappingBoxItemSlack BoxItem { get; }

        [JsonPropertyName("options")]
        public IntegrationMappingSlackOptions Options { get; }

        public UpdateIntegrationMappingSlackByIdRequestBodyArg(IntegrationMappingBoxItemSlack boxItem, IntegrationMappingSlackOptions options) {
            BoxItem = boxItem;
            Options = options;
        }
    }
}