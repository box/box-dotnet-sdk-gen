using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArg {
        /// <summary>
        /// The item to attach the comment to.
        /// </summary>
        [JsonPropertyName("item")]
        public CreateCollaborationRequestBodyArgItemField Item { get; set; }

        /// <summary>
        /// The user or group to give access to the item.
        /// </summary>
        [JsonPropertyName("accessible_by")]
        public CreateCollaborationRequestBodyArgAccessibleByField AccessibleBy { get; set; }

        /// <summary>
        /// The level of access granted.
        /// </summary>
        [JsonPropertyName("role")]
        public CreateCollaborationRequestBodyArgRoleField Role { get; set; }

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

        /// <summary>
        /// Set the expiration date for the collaboration. At this date, the
        /// collaboration will be automatically removed from the item.
        /// 
        /// This feature will only work if the **Automatically remove invited
        /// collaborators: Allow folder owners to extend the expiry date**
        /// setting has been enabled in the **Enterprise Settings**
        /// of the **Admin Console**. When the setting is not enabled,
        /// collaborations can not have an expiry date and a value for this
        /// field will be result in an error.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; } = default;

        public CreateCollaborationRequestBodyArg(CreateCollaborationRequestBodyArgItemField item, CreateCollaborationRequestBodyArgAccessibleByField accessibleBy, CreateCollaborationRequestBodyArgRoleField role) {
            Item = item;
            AccessibleBy = accessibleBy;
            Role = role;
        }
    }
}