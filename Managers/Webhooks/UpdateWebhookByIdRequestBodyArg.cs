using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebhookByIdRequestBodyArg {
        [JsonPropertyName("target")]
        public UpdateWebhookByIdRequestBodyArgTargetField Target { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("triggers")]
        public IReadOnlyList<UpdateWebhookByIdRequestBodyArgTriggersField> Triggers { get; }

        public UpdateWebhookByIdRequestBodyArg(UpdateWebhookByIdRequestBodyArgTargetField target, string address, IReadOnlyList<UpdateWebhookByIdRequestBodyArgTriggersField> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers;
        }
    }
}