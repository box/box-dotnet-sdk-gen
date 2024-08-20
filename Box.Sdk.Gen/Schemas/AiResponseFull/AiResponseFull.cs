using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiResponseFull : AiResponse {
        /// <summary>
        /// The citations of the LLM's answer reference.
        /// </summary>
        [JsonPropertyName("citations")]
        public IReadOnlyList<AiCitation>? Citations { get; init; }

        public AiResponseFull(string answer, System.DateTimeOffset createdAt) : base(answer, createdAt) {
            
        }
    }
}