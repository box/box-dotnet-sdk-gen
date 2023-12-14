using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateSkillInvocationByIdRequestBodyFileVersionTypeField>))]
    public enum UpdateSkillInvocationByIdRequestBodyFileVersionTypeField {
        [Description("file_version")]
        FileVersion
    }
}