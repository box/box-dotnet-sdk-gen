using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderByIdRequestBodyArgSharedLinkField {
        [JsonPropertyName("access")]
        public UpdateFolderByIdRequestBodyArgSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        [JsonPropertyName("permissions")]
        public UpdateFolderByIdRequestBodyArgSharedLinkFieldPermissionsField Permissions { get; }

        public UpdateFolderByIdRequestBodyArgSharedLinkField(UpdateFolderByIdRequestBodyArgSharedLinkFieldAccessField access, string password, string vanityName, string unsharedAt, UpdateFolderByIdRequestBodyArgSharedLinkFieldPermissionsField permissions) {
            Access = access;
            Password = password;
            VanityName = vanityName;
            UnsharedAt = unsharedAt;
            Permissions = permissions;
        }
    }
}