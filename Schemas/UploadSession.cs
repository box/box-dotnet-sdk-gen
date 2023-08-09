using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadSession {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public UploadSessionTypeField Type { get; }

        [JsonPropertyName("session_expires_at")]
        public string SessionExpiresAt { get; }

        [JsonPropertyName("part_size")]
        public int? PartSize { get; }

        [JsonPropertyName("total_parts")]
        public int? TotalParts { get; }

        [JsonPropertyName("num_parts_processed")]
        public int? NumPartsProcessed { get; }

        [JsonPropertyName("session_endpoints")]
        public UploadSessionSessionEndpointsField SessionEndpoints { get; }

        public UploadSession(string id, UploadSessionTypeField type, string sessionExpiresAt, int? partSize, int? totalParts, int? numPartsProcessed, UploadSessionSessionEndpointsField sessionEndpoints) {
            Id = id;
            Type = type;
            SessionExpiresAt = sessionExpiresAt;
            PartSize = partSize;
            TotalParts = totalParts;
            NumPartsProcessed = numPartsProcessed;
            SessionEndpoints = sessionEndpoints;
        }
    }
}