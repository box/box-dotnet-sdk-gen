using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgOpField>))]
    public enum UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArgOpField {
        [Description("replace")]
        Replace
    }
}