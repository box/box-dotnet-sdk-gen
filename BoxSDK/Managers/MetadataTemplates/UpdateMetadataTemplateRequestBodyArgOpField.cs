using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateMetadataTemplateRequestBodyArgOpField>))]
    public enum UpdateMetadataTemplateRequestBodyArgOpField {
        [Description("editTemplate")]
        EditTemplate,
        [Description("addField")]
        AddField,
        [Description("reorderFields")]
        ReorderFields,
        [Description("addEnumOption")]
        AddEnumOption,
        [Description("reorderEnumOptions")]
        ReorderEnumOptions,
        [Description("reorderMultiSelectOptions")]
        ReorderMultiSelectOptions,
        [Description("addMultiSelectOption")]
        AddMultiSelectOption,
        [Description("editField")]
        EditField,
        [Description("removeField")]
        RemoveField,
        [Description("editEnumOption")]
        EditEnumOption,
        [Description("removeEnumOption")]
        RemoveEnumOption,
        [Description("editMultiSelectOption")]
        EditMultiSelectOption,
        [Description("removeMultiSelectOption")]
        RemoveMultiSelectOption
    }
}