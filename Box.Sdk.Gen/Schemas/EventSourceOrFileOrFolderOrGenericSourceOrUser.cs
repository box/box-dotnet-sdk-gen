using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(EventSourceOrFileOrFolderOrGenericSourceOrUserConverter))]
    public class EventSourceOrFileOrFolderOrGenericSourceOrUser : OneOf<EventSource, File, Folder, Dictionary<string, string>, User> {
        public EventSource? EventSource => _val0;
        
        public File? File => _val1;
        
        public Folder? Folder => _val2;
        
        public Dictionary<string, string>? GenericSource => _val3;
        
        public User? User => _val4;
        
        public EventSourceOrFileOrFolderOrGenericSourceOrUser(EventSource value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrGenericSourceOrUser(File value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrGenericSourceOrUser(Folder value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrGenericSourceOrUser(Dictionary<string, string> value) : base(value) {}
        
        public EventSourceOrFileOrFolderOrGenericSourceOrUser(User value) : base(value) {}
        
        public static implicit operator EventSourceOrFileOrFolderOrGenericSourceOrUser(EventSource value) => new EventSourceOrFileOrFolderOrGenericSourceOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrGenericSourceOrUser(File value) => new EventSourceOrFileOrFolderOrGenericSourceOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrGenericSourceOrUser(Folder value) => new EventSourceOrFileOrFolderOrGenericSourceOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrGenericSourceOrUser(Dictionary<string, string> value) => new EventSourceOrFileOrFolderOrGenericSourceOrUser(value);
        
        public static implicit operator EventSourceOrFileOrFolderOrGenericSourceOrUser(User value) => new EventSourceOrFileOrFolderOrGenericSourceOrUser(value);
        
        class EventSourceOrFileOrFolderOrGenericSourceOrUserConverter : JsonConverter<EventSourceOrFileOrFolderOrGenericSourceOrUser> {
            public override EventSourceOrFileOrFolderOrGenericSourceOrUser Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, EventSourceOrFileOrFolderOrGenericSourceOrUser? value, JsonSerializerOptions options) {
            }

        }

    }
}