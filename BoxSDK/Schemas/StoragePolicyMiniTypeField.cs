using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StoragePolicyMiniTypeField>))]
    public enum StoragePolicyMiniTypeField {
        [Description("storage_policy")]
        StoragePolicy
    }
}