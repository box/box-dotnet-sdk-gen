using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(EventSourceOrFileOrFolderOrUserConverter))]
    public class EventSourceOrFileOrFolderOrUser : OneOf<EventSource, File, Folder, User> {
        public EventSource? EventSource => _val0;
        
        public File? File => _val1;
        
        public Folder? Folder => _val2;
        
        public User? User => _val3;
        
        public EventSourceOrFileOrFolderOrUser(EventSource value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrUser(File value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrUser(Folder value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrUser(User value) : base(value) {}
        
        public static implicit operator EventSourceOrFileOrFolderOrUser(EventSource value) => new EventSourceOrFileOrFolderOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrUser(File value) => new EventSourceOrFileOrFolderOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrUser(Folder value) => new EventSourceOrFileOrFolderOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrUser(User value) => new EventSourceOrFileOrFolderOrUser(value);
        
        class EventSourceOrFileOrFolderOrUserConverter : JsonConverter<EventSourceOrFileOrFolderOrUser> {
            public override EventSourceOrFileOrFolderOrUser Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("item_type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<EventSource>(document) ?? throw new Exception($"Could not deserialize {document} to EventSource");
                        case "folder":
                            return JsonSerializer.Deserialize<EventSource>(document) ?? throw new Exception($"Could not deserialize {document} to EventSource");
                    }
                }
                var discriminant1Present = document.RootElement.TryGetProperty("type", out var discriminant1);
                if (discriminant1Present) {
                    switch (discriminant1.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<File>(document) ?? throw new Exception($"Could not deserialize {document} to File");
                        case "folder":
                            return JsonSerializer.Deserialize<Folder>(document) ?? throw new Exception($"Could not deserialize {document} to Folder");
                        case "user":
                            return JsonSerializer.Deserialize<User>(document) ?? throw new Exception($"Could not deserialize {document} to User");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, EventSourceOrFileOrFolderOrUser? value, JsonSerializerOptions options) {
                if (value?.EventSource != null) {
                    JsonSerializer.Serialize(writer, value.EventSource, options);
                    return;
                }
                if (value?.File != null) {
                    JsonSerializer.Serialize(writer, value.File, options);
                    return;
                }
                if (value?.Folder != null) {
                    JsonSerializer.Serialize(writer, value.Folder, options);
                    return;
                }
                if (value?.User != null) {
                    JsonSerializer.Serialize(writer, value.User, options);
                    return;
                }
            }

        }

    }
}