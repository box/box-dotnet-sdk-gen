using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen {
    public class JwtConfigFile {
        /// <summary>
        /// Enterprise ID
        /// </summary>
        [JsonPropertyName("enterpriseID")]
        public string? EnterpriseId { get; init; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonPropertyName("userID")]
        public string? UserId { get; init; }

        /// <summary>
        /// App settings
        /// </summary>
        [JsonPropertyName("boxAppSettings")]
        public JwtConfigAppSettings BoxAppSettings { get; }

        public JwtConfigFile(JwtConfigAppSettings boxAppSettings) {
            BoxAppSettings = boxAppSettings;
        }
    }
}