using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationRequestBodyAccessibleByField {
        /// <summary>
        /// The type of collaborator to invite.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyAccessibleByTypeField Type { get; set; }

        /// <summary>
        /// The ID of the user or group.
        /// 
        /// Alternatively, use `login` to specify a user by email
        /// address.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The email address of the user to grant access to the item.
        /// 
        /// Alternatively, use `id` to specify a user by user ID.
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; } = default;

        public CreateCollaborationRequestBodyAccessibleByField(CreateCollaborationRequestBodyAccessibleByTypeField type) {
            Type = type;
        }
    }
}