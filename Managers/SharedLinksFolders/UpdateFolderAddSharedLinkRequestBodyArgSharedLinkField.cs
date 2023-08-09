using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderAddSharedLinkRequestBodyArgSharedLinkField {
        [JsonPropertyName("access")]
        public UpdateFolderAddSharedLinkRequestBodyArgSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        [JsonPropertyName("permissions")]
        public UpdateFolderAddSharedLinkRequestBodyArgSharedLinkFieldPermissionsField Permissions { get; }

        public UpdateFolderAddSharedLinkRequestBodyArgSharedLinkField(UpdateFolderAddSharedLinkRequestBodyArgSharedLinkFieldAccessField access, string password, string vanityName, string unsharedAt, UpdateFolderAddSharedLinkRequestBodyArgSharedLinkFieldPermissionsField permissions) {
            Access = access;
            Password = password;
            VanityName = vanityName;
            UnsharedAt = unsharedAt;
            Permissions = permissions;
        }
    }
}