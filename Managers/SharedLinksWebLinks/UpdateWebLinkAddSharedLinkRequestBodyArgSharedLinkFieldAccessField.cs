using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkFieldAccessField>))]
    public enum UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkFieldAccessField {
        [Description("open")]
        Open,
        [Description("company")]
        Company,
        [Description("collaborators")]
        Collaborators
    }
}