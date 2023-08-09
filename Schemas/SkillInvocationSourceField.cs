using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(SkillInvocationSourceFieldConverter))]
    public class SkillInvocationSourceField : OneOf<File, Folder> {
        public File File => _val0;
        
        public Folder Folder => _val1;
        
        public SkillInvocationSourceField(File value) : base(value) {}
        
        public SkillInvocationSourceField(Folder value) : base(value) {}
        
        public static implicit operator SkillInvocationSourceField(File value) => new SkillInvocationSourceField(value);
        
        public static implicit operator SkillInvocationSourceField(Folder value) => new SkillInvocationSourceField(value);
        
        class SkillInvocationSourceFieldConverter : JsonConverter<SkillInvocationSourceField> {

            public override SkillInvocationSourceField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<File>(document);
                        case "folder":
                            return JsonSerializer.Deserialize<Folder>(document);
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, SkillInvocationSourceField value, JsonSerializerOptions options) {
                if (value.File != null) {
                    JsonSerializer.Serialize(writer, value.File, options);
                    return;
                }
                if (value.Folder != null) {
                    JsonSerializer.Serialize(writer, value.Folder, options);
                    return;
                }
            }

        }

    }
}