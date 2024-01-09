using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetUsersQueryParamsUserTypeField>))]
    public enum GetUsersQueryParamsUserTypeField {
        [Description("all")]
        All,
        [Description("managed")]
        Managed,
        [Description("external")]
        External
    }
}