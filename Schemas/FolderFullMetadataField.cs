using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderFullMetadataField {
        [JsonPropertyName("extraData")]
        public Dictionary<string, Dictionary<string, Metadata>> ExtraData { get; }

        public FolderFullMetadataField(Dictionary<string, Dictionary<string, Metadata>> extraData) {
            ExtraData = extraData;
        }
    }
}