using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateMetadataTemplateRequestBodyOpField {
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