using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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