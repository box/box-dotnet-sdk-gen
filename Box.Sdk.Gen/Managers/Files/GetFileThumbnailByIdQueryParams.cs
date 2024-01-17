using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetFileThumbnailByIdQueryParams {
        /// <summary>
        /// The minimum height of the thumbnail
        /// </summary>
        public long? MinHeight { get; set; } = default;

        /// <summary>
        /// The minimum width of the thumbnail
        /// </summary>
        public long? MinWidth { get; set; } = default;

        /// <summary>
        /// The maximum height of the thumbnail
        /// </summary>
        public long? MaxHeight { get; set; } = default;

        /// <summary>
        /// The maximum width of the thumbnail
        /// </summary>
        public long? MaxWidth { get; set; } = default;

        public GetFileThumbnailByIdQueryParams() {
            
        }
    }
}