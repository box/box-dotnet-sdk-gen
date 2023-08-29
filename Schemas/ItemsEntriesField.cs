using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(ItemsEntriesFieldConverter))]
    public class ItemsEntriesField : OneOf<FileMini, FolderMini, WebLinkMini> {
        public FileMini? FileMini => _val0;
        
        public FolderMini? FolderMini => _val1;
        
        public WebLinkMini? WebLinkMini => _val2;
        
        public ItemsEntriesField(FileMini value) : base(value) {}
        
        public ItemsEntriesField(FolderMini value) : base(value) {}
        
        public ItemsEntriesField(WebLinkMini value) : base(value) {}
        
        public static implicit operator ItemsEntriesField(FileMini value) => new ItemsEntriesField(value);
        
        public static implicit operator ItemsEntriesField(FolderMini value) => new ItemsEntriesField(value);
        
        public static implicit operator ItemsEntriesField(WebLinkMini value) => new ItemsEntriesField(value);
        
        class ItemsEntriesFieldConverter : JsonConverter<ItemsEntriesField> {

            public override ItemsEntriesField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<FileMini>(document) ?? throw new Exception($"Could not deserialize {document} to FileMini");
                        case "folder":
                            return JsonSerializer.Deserialize<FolderMini>(document) ?? throw new Exception($"Could not deserialize {document} to FolderMini");
                        case "web_link":
                            return JsonSerializer.Deserialize<WebLinkMini>(document) ?? throw new Exception($"Could not deserialize {document} to WebLinkMini");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, ItemsEntriesField? value, JsonSerializerOptions options) {
                if (value?.FileMini != null) {
                    JsonSerializer.Serialize(writer, value.FileMini, options);
                    return;
                }
                if (value?.FolderMini != null) {
                    JsonSerializer.Serialize(writer, value.FolderMini, options);
                    return;
                }
                if (value?.WebLinkMini != null) {
                    JsonSerializer.Serialize(writer, value.WebLinkMini, options);
                    return;
                }
            }

        }

    }
}