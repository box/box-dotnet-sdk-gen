using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetEventsQueryParamsArgStreamTypeField {
        [Description("all")]
        All,
        [Description("changes")]
        Changes,
        [Description("sync")]
        Sync,
        [Description("admin_logs")]
        AdminLogs,
        [Description("admin_logs_streaming")]
        AdminLogsStreaming
    }
}