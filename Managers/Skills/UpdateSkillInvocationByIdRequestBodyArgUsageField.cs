using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBodyArgUsageField {
        [JsonPropertyName("unit")]
        public string Unit { get; }

        [JsonPropertyName("value")]
        public int? Value { get; }

        public UpdateSkillInvocationByIdRequestBodyArgUsageField(string unit, int? value) {
            Unit = unit;
            Value = value;
        }
    }
}