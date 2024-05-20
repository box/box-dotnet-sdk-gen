using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFolderWatermarkRequestBodyWatermarkImprintField Imprint { get; }

        public UpdateFolderWatermarkRequestBodyWatermarkField(UpdateFolderWatermarkRequestBodyWatermarkImprintField imprint = UpdateFolderWatermarkRequestBodyWatermarkImprintField.Default) {
            Imprint = imprint;
        }
    }
}