using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateInviteRequestBody {
        /// <summary>
        /// The enterprise to invite the user to
        /// </summary>
        [JsonPropertyName("enterprise")]
        public CreateInviteRequestBodyEnterpriseField Enterprise { get; }

        /// <summary>
        /// The user to invite
        /// </summary>
        [JsonPropertyName("actionable_by")]
        public CreateInviteRequestBodyActionableByField ActionableBy { get; }

        public CreateInviteRequestBody(CreateInviteRequestBodyEnterpriseField enterprise, CreateInviteRequestBodyActionableByField actionableBy) {
            Enterprise = enterprise;
            ActionableBy = actionableBy;
        }
    }
}