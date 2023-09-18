using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateRetentionPolicyByIdRequestBodyArgDispositionActionField>))]
    public enum UpdateRetentionPolicyByIdRequestBodyArgDispositionActionField {
        [Description("permanently_delete")]
        PermanentlyDelete,
        [Description("remove_retention")]
        RemoveRetention
    }
}