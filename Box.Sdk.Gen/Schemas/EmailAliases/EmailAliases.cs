using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class EmailAliases {
        /// <summary>
        /// The number of email aliases.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; init; }

        /// <summary>
        /// A list of email aliases
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<EmailAlias>? Entries { get; init; }

        public EmailAliases() {
            
        }
    }
}