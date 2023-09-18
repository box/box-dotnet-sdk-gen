using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestCreateSignerRoleField>))]
    public enum SignRequestCreateSignerRoleField {
        [Description("signer")]
        Signer,
        [Description("approver")]
        Approver,
        [Description("final_copy_reader")]
        FinalCopyReader
    }
}