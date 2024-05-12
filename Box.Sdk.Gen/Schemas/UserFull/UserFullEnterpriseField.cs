using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UserFullEnterpriseField {
        /// <summary>
        /// The unique identifier for this enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public UserFullEnterpriseTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the enterprise
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public UserFullEnterpriseField() {
            
        }
    }
}