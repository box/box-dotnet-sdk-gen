using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserCollaborations : UserBase {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("login")]
        public string Login { get; }

        public UserCollaborations(string id, UserBaseTypeField type, string name, string login) : base(id, type) {
            Name = name;
            Login = login;
        }
    }
}