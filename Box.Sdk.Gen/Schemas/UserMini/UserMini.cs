using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UserMini : UserBase {
        /// <summary>
        /// The display name of this user
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The primary email address of this user
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; init; }

        public UserMini(string id, UserBaseTypeField type = UserBaseTypeField.User) : base(id, type) {
            
        }
    }
}