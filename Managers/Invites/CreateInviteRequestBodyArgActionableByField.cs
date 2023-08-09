using System.IO;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArgActionableByField {
        [JsonPropertyName("login")]
        public string Login { get; }

        public CreateInviteRequestBodyArgActionableByField(string login) {
            Login = login;
        }
    }
}