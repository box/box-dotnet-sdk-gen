using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestSignerInputContentTypeField>))]
    public enum SignRequestSignerInputContentTypeField {
        [Description("initial")]
        Initial,
        [Description("stamp")]
        Stamp,
        [Description("signature")]
        Signature,
        [Description("company")]
        Company,
        [Description("title")]
        Title,
        [Description("email")]
        Email,
        [Description("full_name")]
        FullName,
        [Description("first_name")]
        FirstName,
        [Description("last_name")]
        LastName,
        [Description("text")]
        Text,
        [Description("date")]
        Date,
        [Description("checkbox")]
        Checkbox,
        [Description("attachment")]
        Attachment
    }
}