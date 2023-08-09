using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateAdditionalInfoFieldNonEditableField>))]
    public enum SignTemplateAdditionalInfoFieldNonEditableField {
        [Description("email_subject")]
        EmailSubject,
        [Description("email_message")]
        EmailMessage,
        [Description("name")]
        Name,
        [Description("days_valid")]
        DaysValid,
        [Description("signers")]
        Signers,
        [Description("source_files")]
        SourceFiles
    }
}