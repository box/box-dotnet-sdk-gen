using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileAddSharedLinkRequestBodyArgSharedLinkField {
        [JsonPropertyName("access")]
        public UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        [JsonPropertyName("permissions")]
        public UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldPermissionsField Permissions { get; }

        public UpdateFileAddSharedLinkRequestBodyArgSharedLinkField(UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldAccessField access, string password, string vanityName, string unsharedAt, UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldPermissionsField permissions) {
            Access = access;
            Password = password;
            VanityName = vanityName;
            UnsharedAt = unsharedAt;
            Permissions = permissions;
        }
    }
}