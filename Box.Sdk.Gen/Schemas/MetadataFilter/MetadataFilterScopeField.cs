using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum MetadataFilterScopeField {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise,
        [Description("enterprise_{enterprise_id}")]
        EnterpriseEnterpriseId
    }
}