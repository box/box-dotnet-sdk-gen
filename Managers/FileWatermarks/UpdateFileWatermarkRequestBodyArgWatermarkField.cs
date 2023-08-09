using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileWatermarkRequestBodyArgWatermarkField {
        [JsonPropertyName("imprint")]
        public UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField Imprint { get; }

        public UpdateFileWatermarkRequestBodyArgWatermarkField(UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField imprint) {
            Imprint = imprint;
        }
    }
}