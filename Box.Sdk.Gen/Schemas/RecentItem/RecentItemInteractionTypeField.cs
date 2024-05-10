using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RecentItemInteractionTypeField>))]
    public enum RecentItemInteractionTypeField {
        [Description("item_preview")]
        ItemPreview,
        [Description("item_upload")]
        ItemUpload,
        [Description("item_comment")]
        ItemComment,
        [Description("item_open")]
        ItemOpen,
        [Description("item_modify")]
        ItemModify
    }
}