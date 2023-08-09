using System.IO;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArg {
        [JsonPropertyName("enterprise")]
        public CreateInviteRequestBodyArgEnterpriseField Enterprise { get; }

        [JsonPropertyName("actionable_by")]
        public CreateInviteRequestBodyArgActionableByField ActionableBy { get; }

        public CreateInviteRequestBodyArg(CreateInviteRequestBodyArgEnterpriseField enterprise, CreateInviteRequestBodyArgActionableByField actionableBy) {
            Enterprise = enterprise;
            ActionableBy = actionableBy;
        }
    }
}