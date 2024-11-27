using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum SearchForContentQueryParamsContentTypesField {
        [Description("name")]
        Name,
        [Description("description")]
        Description,
        [Description("file_content")]
        FileContent,
        [Description("comments")]
        Comments,
        [Description("tag")]
        Tag
    }
}