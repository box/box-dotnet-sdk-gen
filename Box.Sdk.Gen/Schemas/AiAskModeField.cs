using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<AiAskModeField>))]
    public enum AiAskModeField {
        [Description("multiple_item_qa")]
        MultipleItemQa,
        [Description("single_item_qa")]
        SingleItemQa
    }
}