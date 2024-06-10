using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AppItemEventSource {
        /// <summary>
        /// The id of the `AppItem`
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the source that this event represents. Can be only `app_item`.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public AppItemEventSourceTypeField Type { get; }

        /// <summary>
        /// The type of the `AppItem`
        /// </summary>
        [JsonPropertyName("app_item_type")]
        public string AppItemType { get; }

        [JsonPropertyName("user")]
        public UserMini? User { get; init; }

        [JsonPropertyName("group")]
        public GroupMini? Group { get; init; }

        public AppItemEventSource(string id, string appItemType, AppItemEventSourceTypeField type = AppItemEventSourceTypeField.AppItem) {
            Id = id;
            Type = type;
            AppItemType = appItemType;
        }
    }
}