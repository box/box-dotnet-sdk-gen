using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class PromoteFileVersionRequestBody {
        /// <summary>
        /// The file version ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type to promote
        /// </summary>
        [JsonPropertyName("type")]
        public PromoteFileVersionRequestBodyTypeField? Type { get; init; }

        public PromoteFileVersionRequestBody() {
            
        }
    }
}