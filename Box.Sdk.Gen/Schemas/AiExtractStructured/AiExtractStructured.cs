using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiExtractStructured {
        /// <summary>
        /// The items to be processed by the LLM. Currently you can use files only.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<AiItemBase> Items { get; }

        /// <summary>
        /// The metadata template containing the fields to extract.
        /// For your request to work, you must provide either `metadata_template` or `fields`, but not both.
        /// </summary>
        [JsonPropertyName("metadata_template")]
        public AiExtractStructuredMetadataTemplateField? MetadataTemplate { get; init; }

        /// <summary>
        /// The fields to be extracted from the provided items.
        /// For your request to work, you must provide either `metadata_template` or `fields`, but not both.
        /// </summary>
        [JsonPropertyName("fields")]
        public IReadOnlyList<AiExtractStructuredFieldsField>? Fields { get; init; }

        [JsonPropertyName("ai_agent")]
        public AiAgentExtractStructured? AiAgent { get; init; }

        public AiExtractStructured(IReadOnlyList<AiItemBase> items) {
            Items = items;
        }
    }
}