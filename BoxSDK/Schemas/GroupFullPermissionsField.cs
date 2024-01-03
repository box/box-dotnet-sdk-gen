using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class GroupFullPermissionsField {
        /// <summary>
        /// Specifies if the user can invite the group to collaborate on any items.
        /// </summary>
        [JsonPropertyName("can_invite_as_collaborator")]
        public bool? CanInviteAsCollaborator { get; set; } = default;

        public GroupFullPermissionsField() {
            
        }
    }
}