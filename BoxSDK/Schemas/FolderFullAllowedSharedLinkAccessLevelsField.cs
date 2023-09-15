using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderFullAllowedSharedLinkAccessLevelsField>))]
    public enum FolderFullAllowedSharedLinkAccessLevelsField {
        [Description("open")]
        Open,
        [Description("company")]
        Company,
        [Description("collaborators")]
        Collaborators
    }
}