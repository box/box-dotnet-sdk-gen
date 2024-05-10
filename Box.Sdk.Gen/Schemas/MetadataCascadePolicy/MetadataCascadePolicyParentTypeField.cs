using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyParentTypeField>))]
    public enum MetadataCascadePolicyParentTypeField {
        [Description("folder")]
        Folder
    }
}