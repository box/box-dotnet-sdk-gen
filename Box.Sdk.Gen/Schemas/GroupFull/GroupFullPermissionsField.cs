using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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