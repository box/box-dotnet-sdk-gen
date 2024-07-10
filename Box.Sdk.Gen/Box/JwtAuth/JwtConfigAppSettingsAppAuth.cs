using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen {
    public class JwtConfigAppSettingsAppAuth {
        /// <summary>
        /// Public key ID
        /// </summary>
        [JsonPropertyName("publicKeyID")]
        public string PublicKeyId { get; }

        /// <summary>
        /// Private key
        /// </summary>
        [JsonPropertyName("privateKey")]
        public string PrivateKey { get; }

        /// <summary>
        /// Passphrase
        /// </summary>
        [JsonPropertyName("passphrase")]
        public string Passphrase { get; }

        public JwtConfigAppSettingsAppAuth(string publicKeyId, string privateKey, string passphrase) {
            PublicKeyId = publicKeyId;
            PrivateKey = privateKey;
            Passphrase = passphrase;
        }
    }
}