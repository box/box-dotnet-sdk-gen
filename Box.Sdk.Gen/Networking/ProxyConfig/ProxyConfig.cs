using Box.Sdk.Gen;

namespace Box.Sdk.Gen {
    public class ProxyConfig {
        public string Url { get; }

        public string? Username { get; init; }

        public string? Password { get; init; }

        public string? Domain { get; init; }

        public ProxyConfig(string url) {
            Url = url;
        }
    }
}