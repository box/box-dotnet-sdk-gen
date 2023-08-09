using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldAccessField>))]
    public enum UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldAccessField {
        [Description("open")]
        Open,
        [Description("company")]
        Company,
        [Description("collaborators")]
        Collaborators
    }
}