using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateSharedLinkOnWebLinkRequestBodySharedLinkAccessField>))]
    public enum UpdateSharedLinkOnWebLinkRequestBodySharedLinkAccessField {
        [Description("open")]
        Open,
        [Description("company")]
        Company,
        [Description("collaborators")]
        Collaborators
    }
}