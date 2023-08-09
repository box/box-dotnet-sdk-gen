using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField>))]
    public enum UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArgItemPathField {
        [Description("/Box__Security__Classification__Key")]
        BoxSecurityClassificationKey
    }
}