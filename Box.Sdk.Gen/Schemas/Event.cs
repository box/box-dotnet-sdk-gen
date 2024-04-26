using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class Event {
        /// <summary>
        /// `event`
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// When the event object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the event object was recorded in database
        /// </summary>
        [JsonPropertyName("recorded_at")]
        public System.DateTimeOffset? RecordedAt { get; set; } = default;

        /// <summary>
        /// The ID of the event object. You can use this to detect duplicate events
        /// </summary>
        [JsonPropertyName("event_id")]
        public string? EventId { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        [JsonPropertyName("event_type")]
        public EventEventTypeField? EventType { get; set; } = default;

        /// <summary>
        /// The session of the user that performed the action. Not all events will
        /// populate this attribute.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; } = default;

        [JsonPropertyName("source")]
        public UserOrEventSourceOrFileOrFolderOrGenericSource? Source { get; set; } = default;

        /// <summary>
        /// This object provides additional information about the event if available.
        /// 
        /// This can include how a user performed an event as well as additional
        /// information to correlate an event to external KeySafe logs. Not all events
        /// have an `additional_details` object.  This object is only available in the
        /// Enterprise Events.
        /// </summary>
        [JsonPropertyName("additional_details")]
        public EventAdditionalDetailsField? AdditionalDetails { get; set; } = default;

        public Event() {
            
        }
    }
}