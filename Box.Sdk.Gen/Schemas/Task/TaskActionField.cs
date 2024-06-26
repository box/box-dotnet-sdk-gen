using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum TaskActionField {
        [Description("review")]
        Review,
        [Description("complete")]
        Complete
    }
}