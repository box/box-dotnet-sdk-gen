using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateCollaborationByIdRequestBodyArg {
        [JsonPropertyName("role")]
        public UpdateCollaborationByIdRequestBodyArgRoleField Role { get; }

        [JsonPropertyName("status")]
        public UpdateCollaborationByIdRequestBodyArgStatusField Status { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("can_view_path")]
        public bool? CanViewPath { get; }

        public UpdateCollaborationByIdRequestBodyArg(UpdateCollaborationByIdRequestBodyArgRoleField role, UpdateCollaborationByIdRequestBodyArgStatusField status, string expiresAt, bool? canViewPath) {
            Role = role;
            Status = status;
            ExpiresAt = expiresAt;
            CanViewPath = canViewPath;
        }
    }
}