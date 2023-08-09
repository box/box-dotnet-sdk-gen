using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Event {
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("recorded_at")]
        public string RecordedAt { get; }

        [JsonPropertyName("event_id")]
        public string EventId { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("event_type")]
        public EventEventTypeField EventType { get; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; }

        [JsonPropertyName("source")]
        public EventSourceField Source { get; }

        [JsonPropertyName("additional_details")]
        public EventAdditionalDetailsField AdditionalDetails { get; }

        public Event(string type, string createdAt, string recordedAt, string eventId, UserMini createdBy, EventEventTypeField eventType, string sessionId, EventSourceField source, EventAdditionalDetailsField additionalDetails) {
            Type = type;
            CreatedAt = createdAt;
            RecordedAt = recordedAt;
            EventId = eventId;
            CreatedBy = createdBy;
            EventType = eventType;
            SessionId = sessionId;
            Source = source;
            AdditionalDetails = additionalDetails;
        }
    }
}