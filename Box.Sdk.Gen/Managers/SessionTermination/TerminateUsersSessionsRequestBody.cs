using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class TerminateUsersSessionsRequestBody {
        /// <summary>
        /// A list of user IDs
        /// </summary>
        [JsonPropertyName("user_ids")]
        public IReadOnlyList<string> UserIds { get; }

        /// <summary>
        /// A list of user logins
        /// </summary>
        [JsonPropertyName("user_logins")]
        public IReadOnlyList<string> UserLogins { get; }

        public TerminateUsersSessionsRequestBody(IReadOnlyList<string> userIds, IReadOnlyList<string> userLogins) {
            UserIds = userIds;
            UserLogins = userLogins;
        }
    }
}