using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(CollaborationAccessibleByFieldConverter))]
    public class CollaborationAccessibleByField : OneOf<UserCollaborations, GroupMini> {
        public UserCollaborations? UserCollaborations => _val0;
        
        public GroupMini? GroupMini => _val1;
        
        public CollaborationAccessibleByField(UserCollaborations value) : base(value) {}
        
        public CollaborationAccessibleByField(GroupMini value) : base(value) {}
        
        public static implicit operator CollaborationAccessibleByField(UserCollaborations value) => new CollaborationAccessibleByField(value);
        
        public static implicit operator CollaborationAccessibleByField(GroupMini value) => new CollaborationAccessibleByField(value);
        
        class CollaborationAccessibleByFieldConverter : JsonConverter<CollaborationAccessibleByField> {
            public override CollaborationAccessibleByField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "user":
                            return JsonSerializer.Deserialize<UserCollaborations>(document) ?? throw new Exception($"Could not deserialize {document} to UserCollaborations");
                        case "group":
                            return JsonSerializer.Deserialize<GroupMini>(document) ?? throw new Exception($"Could not deserialize {document} to GroupMini");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, CollaborationAccessibleByField? value, JsonSerializerOptions options) {
                if (value?.UserCollaborations != null) {
                    JsonSerializer.Serialize(writer, value.UserCollaborations, options);
                    return;
                }
                if (value?.GroupMini != null) {
                    JsonSerializer.Serialize(writer, value.GroupMini, options);
                    return;
                }
            }

        }

    }
}