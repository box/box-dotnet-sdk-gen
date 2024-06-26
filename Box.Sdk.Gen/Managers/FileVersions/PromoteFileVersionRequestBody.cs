using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

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
        [JsonConverter(typeof(StringEnumConverter<PromoteFileVersionRequestBodyTypeField>))]
        public StringEnum<PromoteFileVersionRequestBodyTypeField>? Type { get; init; }

        public PromoteFileVersionRequestBody() {
            
        }
    }
}