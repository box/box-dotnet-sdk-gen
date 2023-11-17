using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgFieldKeyField>))]
    public enum UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArgFieldKeyField {
        [Description("Box__Security__Classification__Key")]
        BoxSecurityClassificationKey
    }
}