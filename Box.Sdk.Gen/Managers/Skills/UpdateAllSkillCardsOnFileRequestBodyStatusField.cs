using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateAllSkillCardsOnFileRequestBodyStatusField {
        [Description("invoked")]
        Invoked,
        [Description("processing")]
        Processing,
        [Description("success")]
        Success,
        [Description("transient_failure")]
        TransientFailure,
        [Description("permanent_failure")]
        PermanentFailure
    }
}