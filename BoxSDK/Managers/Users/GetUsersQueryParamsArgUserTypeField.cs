using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetUsersQueryParamsArgUserTypeField>))]
    public enum GetUsersQueryParamsArgUserTypeField {
        [Description("all")]
        All,
        [Description("managed")]
        Managed,
        [Description("external")]
        External
    }
}