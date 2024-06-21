using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateCollaborationByIdRequestBodyStatusField {
        [Description("pending")]
        Pending,
        [Description("accepted")]
        Accepted,
        [Description("rejected")]
        Rejected
    }
}