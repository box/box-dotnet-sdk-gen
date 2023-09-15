using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArg {
        /// <summary>
        /// The enterprise to invite the user to
        /// </summary>
        [JsonPropertyName("enterprise")]
        public CreateInviteRequestBodyArgEnterpriseField Enterprise { get; set; }

        /// <summary>
        /// The user to invite
        /// </summary>
        [JsonPropertyName("actionable_by")]
        public CreateInviteRequestBodyArgActionableByField ActionableBy { get; set; }

        public CreateInviteRequestBodyArg(CreateInviteRequestBodyArgEnterpriseField enterprise, CreateInviteRequestBodyArgActionableByField actionableBy) {
            Enterprise = enterprise;
            ActionableBy = actionableBy;
        }
    }
}