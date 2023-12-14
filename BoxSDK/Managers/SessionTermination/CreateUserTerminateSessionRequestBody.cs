using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserTerminateSessionRequestBody {
        /// <summary>
        /// A list of user IDs
        /// </summary>
        [JsonPropertyName("user_ids")]
        public IReadOnlyList<string> UserIds { get; set; }

        /// <summary>
        /// A list of user logins
        /// </summary>
        [JsonPropertyName("user_logins")]
        public IReadOnlyList<string> UserLogins { get; set; }

        public CreateUserTerminateSessionRequestBody(IReadOnlyList<string> userIds, IReadOnlyList<string> userLogins) {
            UserIds = userIds;
            UserLogins = userLogins;
        }
    }
}