using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationTokenField {
        [JsonPropertyName("read")]
        public SkillInvocationTokenFieldReadField Read { get; }

        [JsonPropertyName("write")]
        public SkillInvocationTokenFieldWriteField Write { get; }

        public SkillInvocationTokenField(SkillInvocationTokenFieldReadField read, SkillInvocationTokenFieldWriteField write) {
            Read = read;
            Write = write;
        }
    }
}