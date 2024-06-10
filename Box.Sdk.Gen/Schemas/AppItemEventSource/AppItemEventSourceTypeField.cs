using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<AppItemEventSourceTypeField>))]
    public enum AppItemEventSourceTypeField {
        [Description("app_item")]
        AppItem
    }
}