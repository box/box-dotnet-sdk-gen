using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileThumbnailByIdQueryParamsArg {
        public int? MinHeight { get; }

        public int? MinWidth { get; }

        public int? MaxHeight { get; }

        public int? MaxWidth { get; }

        public GetFileThumbnailByIdQueryParamsArg(int? minHeight, int? minWidth, int? maxHeight, int? maxWidth) {
            MinHeight = minHeight;
            MinWidth = minWidth;
            MaxHeight = maxHeight;
            MaxWidth = maxWidth;
        }
    }
}