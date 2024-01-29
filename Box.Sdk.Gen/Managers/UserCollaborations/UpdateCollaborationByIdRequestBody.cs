using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateCollaborationByIdRequestBody {
        /// <summary>
        /// The level of access granted.
        /// </summary>
        [JsonPropertyName("role")]
        public UpdateCollaborationByIdRequestBodyRoleField Role { get; set; }

        /// <summary>
        /// <!--alex ignore reject-->
        /// Set the status of a `pending` collaboration invitation,
        /// effectively accepting, or rejecting the invite.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateCollaborationByIdRequestBodyStatusField? Status { get; set; } = default;

        /// <summary>
        /// Update the expiration date for the collaboration. At this date,
        /// the collaboration will be automatically removed from the item.
        /// 
        /// This feature will only work if the **Automatically remove invited
        /// collaborators: Allow folder owners to extend the expiry date**
        /// setting has been enabled in the **Enterprise Settings**
        /// of the **Admin Console**. When the setting is not enabled,
        /// collaborations can not have an expiry date and a value for this
        /// field will be result in an error.
        /// 
        /// Additionally, a collaboration can only be given an
        /// expiration if it was created after the **Automatically remove
        /// invited collaborator** setting was enabled.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; set; } = default;

        /// <summary>
        /// Determines if the invited users can see the entire parent path to
        /// the associated folder. The user will not gain privileges in any
        /// parent folder and therefore can not see content the user is not
        /// collaborated on.
        /// 
        /// Be aware that this meaningfully increases the time required to load the
        /// invitee's **All Files** page. We recommend you limit the number of
        /// collaborations with `can_view_path` enabled to 1,000 per user.
        /// 
        /// Only owner or co-owners can invite collaborators with a `can_view_path` of
        /// `true`.
        /// 
        /// `can_view_path` can only be used for folder collaborations.
        /// </summary>
        [JsonPropertyName("can_view_path")]
        public bool? CanViewPath { get; set; } = default;

        public UpdateCollaborationByIdRequestBody(UpdateCollaborationByIdRequestBodyRoleField role) {
            Role = role;
        }
    }
}