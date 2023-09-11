using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetTermOfServicesQueryParamsArgTosTypeField>))]
    public enum GetTermOfServicesQueryParamsArgTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}