using System.ComponentModel;

namespace Box.Sdk.Gen.Schemas {
    public enum ZipDownloadStatusStateField {
        [Description("in_progress")]
        InProgress,
        [Description("failed")]
        Failed,
        [Description("succeeded")]
        Succeeded
    }
}