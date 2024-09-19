using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiResponseFull : AiResponse, ISerializable {
        /// <summary>
        /// The citations of the LLM's answer reference.
        /// </summary>
        [JsonPropertyName("citations")]
        public IReadOnlyList<AiCitation>? Citations { get; init; }

        public AiResponseFull(string answer, System.DateTimeOffset createdAt) : base(answer, createdAt) {
            
        }
        internal new string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public new Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}