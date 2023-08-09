using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArg {
        [JsonPropertyName("item")]
        public CreateCollaborationRequestBodyArgItemField Item { get; }

        [JsonPropertyName("accessible_by")]
        public CreateCollaborationRequestBodyArgAccessibleByField AccessibleBy { get; }

        [JsonPropertyName("role")]
        public CreateCollaborationRequestBodyArgRoleField Role { get; }

        [JsonPropertyName("can_view_path")]
        public bool? CanViewPath { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        public CreateCollaborationRequestBodyArg(CreateCollaborationRequestBodyArgItemField item, CreateCollaborationRequestBodyArgAccessibleByField accessibleBy, CreateCollaborationRequestBodyArgRoleField role, bool? canViewPath, string expiresAt) {
            Item = item;
            AccessibleBy = accessibleBy;
            Role = role;
            CanViewPath = canViewPath;
            ExpiresAt = expiresAt;
        }
    }
}