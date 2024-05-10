using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class TimelineSkillCardEntriesField {
        /// <summary>
        /// The text of the entry. This would be the display
        /// name for an item being placed on the timeline, for example the name
        /// of the person who was detected in a video.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; } = default;

        /// <summary>
        /// Defines a list of timestamps for when this item should appear on the
        /// timeline.
        /// </summary>
        [JsonPropertyName("appears")]
        public IReadOnlyList<TimelineSkillCardEntriesAppearsField>? Appears { get; set; } = default;

        /// <summary>
        /// The image to show on a for an entry that appears
        /// on a timeline. This image URL is required for every entry.
        /// 
        /// The image will be shown in a
        /// list of items (for example faces), and clicking
        /// the image will show the user where that entry
        /// appears during the duration of this entry.
        /// </summary>
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; } = default;

        public TimelineSkillCardEntriesField() {
            
        }
    }
}