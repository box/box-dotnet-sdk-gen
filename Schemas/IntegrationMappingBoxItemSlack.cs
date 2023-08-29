using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingBoxItemSlack {
        /// <summary>
        /// Type of the mapped item referenced in `id`
        /// </summary>
        [JsonPropertyName("type")]
        public IntegrationMappingBoxItemSlackTypeField Type { get; set; }

        /// <summary>
        /// ID of the mapped item (of type referenced in `type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public IntegrationMappingBoxItemSlack(IntegrationMappingBoxItemSlackTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}