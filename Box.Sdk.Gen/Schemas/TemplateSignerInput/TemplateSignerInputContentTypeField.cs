using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TemplateSignerInputContentTypeField>))]
    public enum TemplateSignerInputContentTypeField {
        [Description("signature")]
        Signature,
        [Description("initial")]
        Initial,
        [Description("stamp")]
        Stamp,
        [Description("date")]
        Date,
        [Description("checkbox")]
        Checkbox,
        [Description("text")]
        Text,
        [Description("full_name")]
        FullName,
        [Description("first_name")]
        FirstName,
        [Description("last_name")]
        LastName,
        [Description("company")]
        Company,
        [Description("title")]
        Title,
        [Description("email")]
        Email,
        [Description("attachment")]
        Attachment,
        [Description("radio")]
        Radio,
        [Description("dropdown")]
        Dropdown
    }
}