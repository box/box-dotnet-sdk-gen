using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class IntegrationMappingBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("integration_type")]
        public IntegrationMappingBaseIntegrationTypeField IntegrationType { get; }

        public IntegrationMappingBase(string id, IntegrationMappingBaseIntegrationTypeField integrationType) {
            Id = id;
            IntegrationType = integrationType;
        }
    }
}