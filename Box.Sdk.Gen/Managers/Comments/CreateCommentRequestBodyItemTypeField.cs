using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public enum CreateCommentRequestBodyItemTypeField {
        [Description("file")]
        File,
        [Description("comment")]
        Comment
    }
}