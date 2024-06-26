using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum CollaborationStatusField {
        [Description("accepted")]
        Accepted,
        [Description("pending")]
        Pending,
        [Description("rejected")]
        Rejected
    }
}