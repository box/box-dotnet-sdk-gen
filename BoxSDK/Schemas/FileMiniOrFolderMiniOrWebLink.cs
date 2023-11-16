using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(FileMiniOrFolderMiniOrWebLinkConverter))]
    public class FileMiniOrFolderMiniOrWebLink : OneOf<FileMini, FolderMini, WebLink> {
        public FileMini? FileMini => _val0;
        
        public FolderMini? FolderMini => _val1;
        
        public WebLink? WebLink => _val2;
        
        public FileMiniOrFolderMiniOrWebLink(FileMini value) : base(value) {}
        
        public FileMiniOrFolderMiniOrWebLink(FolderMini value) : base(value) {}
        
        public FileMiniOrFolderMiniOrWebLink(WebLink value) : base(value) {}
        
        public static implicit operator FileMiniOrFolderMiniOrWebLink(FileMini value) => new FileMiniOrFolderMiniOrWebLink(value);
        
        public static implicit operator FileMiniOrFolderMiniOrWebLink(FolderMini value) => new FileMiniOrFolderMiniOrWebLink(value);
        
        public static implicit operator FileMiniOrFolderMiniOrWebLink(WebLink value) => new FileMiniOrFolderMiniOrWebLink(value);
        
        class FileMiniOrFolderMiniOrWebLinkConverter : JsonConverter<FileMiniOrFolderMiniOrWebLink> {
            public override FileMiniOrFolderMiniOrWebLink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<FileMini>(document) ?? throw new Exception($"Could not deserialize {document} to FileMini");
                        case "folder":
                            return JsonSerializer.Deserialize<FolderMini>(document) ?? throw new Exception($"Could not deserialize {document} to FolderMini");
                        case "web_link":
                            return JsonSerializer.Deserialize<WebLink>(document) ?? throw new Exception($"Could not deserialize {document} to WebLink");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, FileMiniOrFolderMiniOrWebLink? value, JsonSerializerOptions options) {
                if (value?.FileMini != null) {
                    JsonSerializer.Serialize(writer, value.FileMini, options);
                    return;
                }
                if (value?.FolderMini != null) {
                    JsonSerializer.Serialize(writer, value.FolderMini, options);
                    return;
                }
                if (value?.WebLink != null) {
                    JsonSerializer.Serialize(writer, value.WebLink, options);
                    return;
                }
            }

        }

    }
}