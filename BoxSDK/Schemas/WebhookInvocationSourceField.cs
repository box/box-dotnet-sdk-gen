using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(WebhookInvocationSourceFieldConverter))]
    public class WebhookInvocationSourceField : OneOf<File, Folder> {
        public File? File => _val0;
        
        public Folder? Folder => _val1;
        
        public WebhookInvocationSourceField(File value) : base(value) {}
        
        public WebhookInvocationSourceField(Folder value) : base(value) {}
        
        public static implicit operator WebhookInvocationSourceField(File value) => new WebhookInvocationSourceField(value);
        
        public static implicit operator WebhookInvocationSourceField(Folder value) => new WebhookInvocationSourceField(value);
        
        class WebhookInvocationSourceFieldConverter : JsonConverter<WebhookInvocationSourceField> {
            public override WebhookInvocationSourceField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<File>(document) ?? throw new Exception($"Could not deserialize {document} to File");
                        case "folder":
                            return JsonSerializer.Deserialize<Folder>(document) ?? throw new Exception($"Could not deserialize {document} to Folder");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, WebhookInvocationSourceField? value, JsonSerializerOptions options) {
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