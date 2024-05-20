using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateUserEmailAliasRequestBody {
        /// <summary>
        /// The email address to add to the account as an alias.
        /// 
        /// Note: The domain of the email alias needs to be registered
        ///  to your enterprise.
        /// See the [domain verification guide](
        ///   https://support.box.com/hc/en-us/articles/4408619650579-Domain-Verification
        ///   ) for steps to add a new domain.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; }

        public CreateUserEmailAliasRequestBody(string email) {
            Email = email;
        }
    }
}