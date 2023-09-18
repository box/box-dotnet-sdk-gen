using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EmailAliases {
        /// <summary>
        /// The number of email aliases.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of email aliases
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<EmailAlias>? Entries { get; set; } = default;

        public EmailAliases() {
            
        }
    }
}