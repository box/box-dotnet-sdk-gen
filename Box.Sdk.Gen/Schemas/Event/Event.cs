using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Event {
        /// <summary>
        /// `event`
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        /// <summary>
        /// When the event object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the event object was recorded in database
        /// </summary>
        [JsonPropertyName("recorded_at")]
        public System.DateTimeOffset? RecordedAt { get; init; }

        /// <summary>
        /// The ID of the event object. You can use this to detect duplicate events
        /// </summary>
        [JsonPropertyName("event_id")]
        public string? EventId { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        [JsonPropertyName("event_type")]
        public EventEventTypeField? EventType { get; init; }

        /// <summary>
        /// The session of the user that performed the action. Not all events will
        /// populate this attribute.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string? SessionId { get; init; }

        [JsonPropertyName("source")]
        public EventSourceOrFileOrFolderOrGenericSourceOrUser? Source { get; init; }

        /// <summary>
        /// This object provides additional information about the event if available.
        /// 
        /// This can include how a user performed an event as well as additional
        /// information to correlate an event to external KeySafe logs. Not all events
        /// have an `additional_details` object.  This object is only available in the
        /// Enterprise Events.
        /// </summary>
        [JsonPropertyName("additional_details")]
        public EventAdditionalDetailsField? AdditionalDetails { get; init; }

        public Event() {
            
        }
    }
}