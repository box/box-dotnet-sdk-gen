using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum CreateTaskRequestBodyActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}