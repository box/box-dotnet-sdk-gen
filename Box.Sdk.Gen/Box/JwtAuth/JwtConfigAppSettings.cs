using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen {
    public class JwtConfigAppSettings {
        /// <summary>
        /// App client ID
        /// </summary>
        [JsonPropertyName("clientID")]
        public string ClientId { get; }

        /// <summary>
        /// App client secret
        /// </summary>
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; }

        /// <summary>
        /// App auth settings
        /// </summary>
        [JsonPropertyName("appAuth")]
        public JwtConfigAppSettingsAppAuth AppAuth { get; }

        public JwtConfigAppSettings(string clientId, string clientSecret, JwtConfigAppSettingsAppAuth appAuth) {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AppAuth = appAuth;
        }
    }
}