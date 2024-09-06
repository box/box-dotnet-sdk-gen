using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class AppItem {
        /// <summary>
        /// The unique identifier for this app item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `app_item`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AppItemTypeField>))]
        public StringEnum<AppItemTypeField> Type { get; }

        /// <summary>
        /// The type of the app that owns this app item.
        /// </summary>
        [JsonPropertyName("application_type")]
        public string ApplicationType { get; }

        public AppItem(string id, string applicationType, AppItemTypeField type = AppItemTypeField.AppItem) {
            Id = id;
            Type = type;
            ApplicationType = applicationType;
        }
        
        [JsonConstructorAttribute]
        internal AppItem(string id, string applicationType, StringEnum<AppItemTypeField> type) {
            Id = id;
            Type = AppItemTypeField.AppItem;
            ApplicationType = applicationType;
        }
    }
}