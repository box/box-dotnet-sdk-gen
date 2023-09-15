using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(EventSourceFieldConverter))]
    public class EventSourceField : OneOf<User, EventSource, File, Folder> {
        public User? User => _val0;
        
        public EventSource? EventSource => _val1;
        
        public File? File => _val2;
        
        public Folder? Folder => _val3;
        
        public EventSourceField(User value) : base(value) {}
        
        public EventSourceField(EventSource value) : base(value) {}
        
        public EventSourceField(File value) : base(value) {}
        
        public EventSourceField(Folder value) : base(value) {}
        
        public static implicit operator EventSourceField(User value) => new EventSourceField(value);
        
        public static implicit operator EventSourceField(EventSource value) => new EventSourceField(value);
        
        public static implicit operator EventSourceField(File value) => new EventSourceField(value);
        
        public static implicit operator EventSourceField(Folder value) => new EventSourceField(value);
        
        class EventSourceFieldConverter : JsonConverter<EventSourceField> {
            public override EventSourceField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "user":
                            return JsonSerializer.Deserialize<User>(document) ?? throw new Exception($"Could not deserialize {document} to User");
                        case "file":
                            return JsonSerializer.Deserialize<File>(document) ?? throw new Exception($"Could not deserialize {document} to File");
                        case "folder":
                            return JsonSerializer.Deserialize<Folder>(document) ?? throw new Exception($"Could not deserialize {document} to Folder");
                    }
                }
                var discriminant1Present = document.RootElement.TryGetProperty("item_type", out var discriminant1);
                if (discriminant1Present) {
                    switch (discriminant1.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<EventSource>(document) ?? throw new Exception($"Could not deserialize {document} to EventSource");
                        case "folder":
                            return JsonSerializer.Deserialize<EventSource>(document) ?? throw new Exception($"Could not deserialize {document} to EventSource");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, EventSourceField? value, JsonSerializerOptions options) {
                if (value?.User != null) {
                    JsonSerializer.Serialize(writer, value.User, options);
                    return;
                }
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
            }

        }

    }
}