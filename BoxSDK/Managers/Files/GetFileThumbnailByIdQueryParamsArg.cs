using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileThumbnailByIdQueryParamsArg {
        /// <summary>
        /// The minimum height of the thumbnail
        /// </summary>
        public int? MinHeight { get; set; } = default;

        /// <summary>
        /// The minimum width of the thumbnail
        /// </summary>
        public int? MinWidth { get; set; } = default;

        /// <summary>
        /// The maximum height of the thumbnail
        /// </summary>
        public int? MaxHeight { get; set; } = default;

        /// <summary>
        /// The maximum width of the thumbnail
        /// </summary>
        public int? MaxWidth { get; set; } = default;

        public GetFileThumbnailByIdQueryParamsArg() {
            
        }
    }
}