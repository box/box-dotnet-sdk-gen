using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class UserBase {
        /// <summary>
        /// The unique identifier for this user
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `user`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<UserBaseTypeField>))]
        public StringEnum<UserBaseTypeField> Type { get; }

        public UserBase(string id, UserBaseTypeField type = UserBaseTypeField.User) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal UserBase(string id, StringEnum<UserBaseTypeField> type) {
            Id = id;
            Type = UserBaseTypeField.User;
        }
    }
}