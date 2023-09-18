using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FolderMini : FolderBase {
        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// A numeric identifier that represents the most recent user event
        /// that has been applied to this item.
        /// 
        /// This can be used in combination with the `GET /events`-endpoint
        /// to filter out user events that would have occurred before this
        /// identifier was read.
        /// 
        /// An example would be where a Box Drive-like application
        /// would fetch an item via the API, and then listen to incoming
        /// user events for changes to the item. The application would
        /// ignore any user events where the `sequence_id` in the event
        /// is smaller than or equal to the `sequence_id` in the originally
        /// fetched resource.
        /// </summary>
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        public FolderMini(string id, FolderBaseTypeField type) : base(id, type) {
            
        }
    }
}