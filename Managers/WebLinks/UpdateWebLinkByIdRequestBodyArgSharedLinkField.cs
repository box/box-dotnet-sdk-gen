using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkByIdRequestBodyArgSharedLinkField {
        [JsonPropertyName("access")]
        public UpdateWebLinkByIdRequestBodyArgSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        public UpdateWebLinkByIdRequestBodyArgSharedLinkField(UpdateWebLinkByIdRequestBodyArgSharedLinkFieldAccessField access, string password, string vanityName, string unsharedAt) {
            Access = access;
            Password = password;
            VanityName = vanityName;
            UnsharedAt = unsharedAt;
        }
    }
}