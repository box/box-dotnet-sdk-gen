using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkField {
        [JsonPropertyName("access")]
        public UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        [JsonPropertyName("permissions")]
        public UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkFieldPermissionsField Permissions { get; }

        public UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkField(UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField access, string password, string vanityName, string unsharedAt, UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkFieldPermissionsField permissions) {
            Access = access;
            Password = password;
            VanityName = vanityName;
            UnsharedAt = unsharedAt;
            Permissions = permissions;
        }
    }
}