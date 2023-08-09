using System.IO;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserTerminateSessionRequestBodyArg {
        [JsonPropertyName("user_ids")]
        public IReadOnlyList<string> UserIds { get; }

        [JsonPropertyName("user_logins")]
        public IReadOnlyList<string> UserLogins { get; }

        public CreateUserTerminateSessionRequestBodyArg(IReadOnlyList<string> userIds, IReadOnlyList<string> userLogins) {
            UserIds = userIds;
            UserLogins = userLogins;
        }
    }
}