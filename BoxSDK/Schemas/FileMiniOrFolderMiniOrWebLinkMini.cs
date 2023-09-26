using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(FileMiniOrFolderMiniOrWebLinkMiniConverter))]
    public class FileMiniOrFolderMiniOrWebLinkMini : OneOf<FileMini, FolderMini, WebLinkMini> {
        public FileMini? FileMini => _val0;
        
        public FolderMini? FolderMini => _val1;
        
        public WebLinkMini? WebLinkMini => _val2;
        
        public FileMiniOrFolderMiniOrWebLinkMini(FileMini value) : base(value) {}
        
        public FileMiniOrFolderMiniOrWebLinkMini(FolderMini value) : base(value) {}
        
        public FileMiniOrFolderMiniOrWebLinkMini(WebLinkMini value) : base(value) {}
        
        public static implicit operator FileMiniOrFolderMiniOrWebLinkMini(FileMini value) => new FileMiniOrFolderMiniOrWebLinkMini(value);
        
        public static implicit operator FileMiniOrFolderMiniOrWebLinkMini(FolderMini value) => new FileMiniOrFolderMiniOrWebLinkMini(value);
        
        public static implicit operator FileMiniOrFolderMiniOrWebLinkMini(WebLinkMini value) => new FileMiniOrFolderMiniOrWebLinkMini(value);
        
        class FileMiniOrFolderMiniOrWebLinkMiniConverter : JsonConverter<FileMiniOrFolderMiniOrWebLinkMini> {
            public override FileMiniOrFolderMiniOrWebLinkMini Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
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

            public override void Write(Utf8JsonWriter writer, FileMiniOrFolderMiniOrWebLinkMini? value, JsonSerializerOptions options) {
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