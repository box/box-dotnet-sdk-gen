using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TemplateSignerRoleField>))]
    public enum TemplateSignerRoleField {
        [Description("signer")]
        Signer,
        [Description("approver")]
        Approver,
        [Description("final_copy_reader")]
        FinalCopyReader
    }
}