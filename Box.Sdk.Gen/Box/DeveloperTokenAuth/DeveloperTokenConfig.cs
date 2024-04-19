using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen {
    public class DeveloperTokenConfig {
        public string? ClientId { get; set; } = default;

        public string? ClientSecret { get; set; } = default;

        public DeveloperTokenConfig() {
            
        }
    }
}