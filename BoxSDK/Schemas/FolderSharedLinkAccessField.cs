using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderSharedLinkAccessField>))]
    public enum FolderSharedLinkAccessField {
        [Description("open")]
        Open,
        [Description("company")]
        Company,
        [Description("collaborators")]
        Collaborators
    }
}