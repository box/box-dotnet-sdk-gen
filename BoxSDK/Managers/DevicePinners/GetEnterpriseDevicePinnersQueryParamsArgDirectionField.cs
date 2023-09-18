using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetEnterpriseDevicePinnersQueryParamsArgDirectionField>))]
    public enum GetEnterpriseDevicePinnersQueryParamsArgDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}