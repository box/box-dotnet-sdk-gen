using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileWatermarkRequestBody {
        /// <summary>
        /// The watermark to imprint on the file
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFileWatermarkRequestBodyWatermarkField Watermark { get; }

        public UpdateFileWatermarkRequestBody(UpdateFileWatermarkRequestBodyWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}