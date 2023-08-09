using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupFullPermissionsField {
        [JsonPropertyName("can_invite_as_collaborator")]
        public bool? CanInviteAsCollaborator { get; }

        public GroupFullPermissionsField(bool? canInviteAsCollaborator) {
            CanInviteAsCollaborator = canInviteAsCollaborator;
        }
    }
}