using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateAdditionalInfoNonEditableField>))]
    public enum SignTemplateAdditionalInfoNonEditableField {
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