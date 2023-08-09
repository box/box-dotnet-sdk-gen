using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyParentFieldTypeField>))]
    public enum MetadataCascadePolicyParentFieldTypeField {
        [Description("folder")]
        Folder
    }
}