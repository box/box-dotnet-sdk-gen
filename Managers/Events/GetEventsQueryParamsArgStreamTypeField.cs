using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetEventsQueryParamsArgStreamTypeField>))]
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