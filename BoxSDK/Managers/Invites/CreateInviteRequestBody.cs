using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBody {
        /// <summary>
        /// The enterprise to invite the user to
        /// </summary>
        [JsonPropertyName("enterprise")]
        public CreateInviteRequestBodyEnterpriseField Enterprise { get; set; }

        /// <summary>
        /// The user to invite
        /// </summary>
        [JsonPropertyName("actionable_by")]
        public CreateInviteRequestBodyActionableByField ActionableBy { get; set; }

        public CreateInviteRequestBody(CreateInviteRequestBodyEnterpriseField enterprise, CreateInviteRequestBodyActionableByField actionableBy) {
            Enterprise = enterprise;
            ActionableBy = actionableBy;
        }
    }
}