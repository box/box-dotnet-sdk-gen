using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServiceUserStatuses {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TermsOfServiceUserStatus> Entries { get; }

        public TermsOfServiceUserStatuses(int? totalCount, IReadOnlyList<TermsOfServiceUserStatus> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}