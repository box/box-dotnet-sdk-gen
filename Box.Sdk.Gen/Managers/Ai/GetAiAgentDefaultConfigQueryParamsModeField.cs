using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum GetAiAgentDefaultConfigQueryParamsModeField {
        [Description("ask")]
        Ask,
        [Description("text_gen")]
        TextGen,
        [Description("extract")]
        Extract,
        [Description("extract_structured")]
        ExtractStructured
    }
}