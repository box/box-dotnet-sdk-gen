using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class EnterpriseBase {
        /// <summary>
        /// The unique identifier for this enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<EnterpriseBaseTypeField>))]
        public StringEnum<EnterpriseBaseTypeField>? Type { get; init; }

        public EnterpriseBase() {
            
        }
    }
}