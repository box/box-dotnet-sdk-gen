using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum ShieldInformationBarrierReportStatusField {
        [Description("pending")]
        Pending,
        [Description("error")]
        Error,
        [Description("done")]
        Done,
        [Description("cancelled")]
        Cancelled
    }
}