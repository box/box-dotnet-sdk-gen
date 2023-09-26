using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArgAccessibleByField {
        /// <summary>
        /// The type of collaborator to invite.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyArgAccessibleByFieldTypeField Type { get; set; }

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

        public CreateCollaborationRequestBodyArgAccessibleByField(CreateCollaborationRequestBodyArgAccessibleByFieldTypeField type) {
            Type = type;
        }
    }
}