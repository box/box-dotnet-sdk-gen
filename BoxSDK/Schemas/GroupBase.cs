using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupBase {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `group`
        /// </summary>
        [JsonPropertyName("type")]
        public GroupBaseTypeField Type { get; set; }

        public GroupBase(string id, GroupBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}