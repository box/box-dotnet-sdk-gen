using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationStatusField {
        [JsonPropertyName("state")]
        public SkillInvocationStatusFieldStateField State { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; }

        [JsonPropertyName("additional_info")]
        public string AdditionalInfo { get; }

        public SkillInvocationStatusField(SkillInvocationStatusFieldStateField state, string message, string errorCode, string additionalInfo) {
            State = state;
            Message = message;
            ErrorCode = errorCode;
            AdditionalInfo = additionalInfo;
        }
    }
}