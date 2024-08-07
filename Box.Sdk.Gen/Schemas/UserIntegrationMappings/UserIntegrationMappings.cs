using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class UserIntegrationMappings : UserBase {
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

        public UserIntegrationMappings(string id, UserBaseTypeField type = UserBaseTypeField.User) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal UserIntegrationMappings(string id, StringEnum<UserBaseTypeField> type) : base(id, type ?? new StringEnum<UserBaseTypeField>(UserBaseTypeField.User)) {
            
        }
    }
}