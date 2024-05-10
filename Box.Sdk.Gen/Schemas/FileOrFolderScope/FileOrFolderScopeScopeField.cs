using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileOrFolderScopeScopeField>))]
    public enum FileOrFolderScopeScopeField {
        [Description("annotation_edit")]
        AnnotationEdit,
        [Description("annotation_view_all")]
        AnnotationViewAll,
        [Description("annotation_view_self")]
        AnnotationViewSelf,
        [Description("base_explorer")]
        BaseExplorer,
        [Description("base_picker")]
        BasePicker,
        [Description("base_preview")]
        BasePreview,
        [Description("base_upload")]
        BaseUpload,
        [Description("item_delete")]
        ItemDelete,
        [Description("item_download")]
        ItemDownload,
        [Description("item_preview")]
        ItemPreview,
        [Description("item_rename")]
        ItemRename,
        [Description("item_share")]
        ItemShare
    }
}