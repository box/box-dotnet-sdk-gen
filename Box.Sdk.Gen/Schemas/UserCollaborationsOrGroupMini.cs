using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(UserCollaborationsOrGroupMiniConverter))]
    public class UserCollaborationsOrGroupMini : OneOf<GroupMini, UserCollaborations> {
        public GroupMini? GroupMini => _val0;
        
        public UserCollaborations? UserCollaborations => _val1;
        
        public UserCollaborationsOrGroupMini(GroupMini value) : base(value) {}
        
        public UserCollaborationsOrGroupMini(UserCollaborations value) : base(value) {}
        
        public static implicit operator UserCollaborationsOrGroupMini(GroupMini value) => new UserCollaborationsOrGroupMini(value);
        
        public static implicit operator UserCollaborationsOrGroupMini(UserCollaborations value) => new UserCollaborationsOrGroupMini(value);
        
        class UserCollaborationsOrGroupMiniConverter : JsonConverter<UserCollaborationsOrGroupMini> {
            public override UserCollaborationsOrGroupMini Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "group":
                            return JsonSerializer.Deserialize<GroupMini>(document) ?? throw new Exception($"Could not deserialize {document} to GroupMini");
                        case "user":
                            return JsonSerializer.Deserialize<UserCollaborations>(document) ?? throw new Exception($"Could not deserialize {document} to UserCollaborations");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, UserCollaborationsOrGroupMini? value, JsonSerializerOptions options) {
                if (value?.GroupMini != null) {
                    JsonSerializer.Serialize(writer, value.GroupMini, options);
                    return;
                }
                if (value?.UserCollaborations != null) {
                    JsonSerializer.Serialize(writer, value.UserCollaborations, options);
                    return;
                }
            }

        }

    }
}