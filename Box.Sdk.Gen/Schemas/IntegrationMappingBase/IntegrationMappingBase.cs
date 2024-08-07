using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingBase {
        /// <summary>
        /// A unique identifier of a folder mapping
        /// (part of a composite key together
        /// with `integration_type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// Identifies the Box partner app,
        /// with which the mapping is associated.
        /// Currently only supports Slack.
        /// (part of the composite key together with `id`)
        /// </summary>
        [JsonPropertyName("integration_type")]
        [JsonConverter(typeof(StringEnumConverter<IntegrationMappingBaseIntegrationTypeField>))]
        public StringEnum<IntegrationMappingBaseIntegrationTypeField>? IntegrationType { get; init; }

        public IntegrationMappingBase() {
            
        }
    }
}