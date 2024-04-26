using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(FolderMiniOrFileMiniConverter))]
    public class FolderMiniOrFileMini : OneOf<FileMini, FolderMini> {
        public FileMini? FileMini => _val0;
        
        public FolderMini? FolderMini => _val1;
        
        public FolderMiniOrFileMini(FileMini value) : base(value) {}
        
        public FolderMiniOrFileMini(FolderMini value) : base(value) {}
        
        public static implicit operator FolderMiniOrFileMini(FileMini value) => new FolderMiniOrFileMini(value);
        
        public static implicit operator FolderMiniOrFileMini(FolderMini value) => new FolderMiniOrFileMini(value);
        
        class FolderMiniOrFileMiniConverter : JsonConverter<FolderMiniOrFileMini> {
            public override FolderMiniOrFileMini Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "file":
                            return JsonSerializer.Deserialize<FileMini>(document) ?? throw new Exception($"Could not deserialize {document} to FileMini");
                        case "folder":
                            return JsonSerializer.Deserialize<FolderMini>(document) ?? throw new Exception($"Could not deserialize {document} to FolderMini");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, FolderMiniOrFileMini? value, JsonSerializerOptions options) {
                if (value?.FileMini != null) {
                    JsonSerializer.Serialize(writer, value.FileMini, options);
                    return;
                }
                if (value?.FolderMini != null) {
                    JsonSerializer.Serialize(writer, value.FolderMini, options);
                    return;
                }
            }

        }

    }
}