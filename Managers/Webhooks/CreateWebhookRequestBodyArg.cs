using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebhookRequestBodyArg {
        [JsonPropertyName("target")]
        public CreateWebhookRequestBodyArgTargetField Target { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("triggers")]
        public IReadOnlyList<CreateWebhookRequestBodyArgTriggersField> Triggers { get; }

        public CreateWebhookRequestBodyArg(CreateWebhookRequestBodyArgTargetField target, string address, IReadOnlyList<CreateWebhookRequestBodyArgTriggersField> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers;
        }
    }
}