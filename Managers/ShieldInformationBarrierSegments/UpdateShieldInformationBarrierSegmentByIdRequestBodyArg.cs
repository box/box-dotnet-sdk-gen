using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateShieldInformationBarrierSegmentByIdRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        public UpdateShieldInformationBarrierSegmentByIdRequestBodyArg(string name, string description) {
            Name = name;
            Description = description;
        }
    }
}