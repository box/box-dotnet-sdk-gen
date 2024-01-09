using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingBase {
        /// <summary>
        /// A unique identifier of a folder mapping
        /// (part of a composite key together
        /// with `integration_type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// Identifies the Box partner app,
        /// with which the mapping is associated.
        /// Currently only supports Slack.
        /// (part of the composite key together with `id`)
        /// </summary>
        [JsonPropertyName("integration_type")]
        public IntegrationMappingBaseIntegrationTypeField? IntegrationType { get; set; } = default;

        public IntegrationMappingBase() {
            
        }
    }
}