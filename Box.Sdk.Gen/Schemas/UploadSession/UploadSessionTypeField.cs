using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UploadSessionTypeField>))]
    public enum UploadSessionTypeField {
        [Description("upload_session")]
        UploadSession
    }
}