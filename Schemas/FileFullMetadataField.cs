using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullMetadataField {
        [JsonPropertyName("extraData")]
        public Dictionary<string, Dictionary<string, Metadata>> ExtraData { get; }

        public FileFullMetadataField(Dictionary<string, Dictionary<string, Metadata>> extraData) {
            ExtraData = extraData;
        }
    }
}