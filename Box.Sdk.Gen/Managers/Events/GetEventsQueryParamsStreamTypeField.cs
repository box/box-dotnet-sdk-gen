using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetEventsQueryParamsStreamTypeField>))]
    public enum GetEventsQueryParamsStreamTypeField {
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