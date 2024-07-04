using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UserCollaborations : UserBase {
        /// <summary>
        /// The display name of this user. If the collaboration status is `pending`, an empty string is returned.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The primary email address of this user. If the collaboration status is `pending`, an empty string is returned.
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; init; }

        public UserCollaborations(string id, UserBaseTypeField type = UserBaseTypeField.User) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal UserCollaborations(string id, StringEnum<UserBaseTypeField> type) : base(id, type ?? new StringEnum<UserBaseTypeField>(UserBaseTypeField.User)) {
            
        }
    }
}