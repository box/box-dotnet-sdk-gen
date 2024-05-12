using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestStatusField>))]
    public enum SignRequestStatusField {
        [Description("converting")]
        Converting,
        [Description("created")]
        Created,
        [Description("sent")]
        Sent,
        [Description("viewed")]
        Viewed,
        [Description("signed")]
        Signed,
        [Description("cancelled")]
        Cancelled,
        [Description("declined")]
        Declined,
        [Description("error_converting")]
        ErrorConverting,
        [Description("error_sending")]
        ErrorSending,
        [Description("expired")]
        Expired,
        [Description("finalizing")]
        Finalizing,
        [Description("error_finalizing")]
        ErrorFinalizing
    }
}