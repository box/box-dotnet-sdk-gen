using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
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