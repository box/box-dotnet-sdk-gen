using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserEmailAliasRequestBodyArg {
        [JsonPropertyName("email")]
        public string Email { get; }

        public CreateUserEmailAliasRequestBodyArg(string email) {
            Email = email;
        }
    }
}