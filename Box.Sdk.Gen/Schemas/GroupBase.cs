using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
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