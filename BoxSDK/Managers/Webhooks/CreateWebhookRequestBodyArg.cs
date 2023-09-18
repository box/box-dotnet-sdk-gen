using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebhookRequestBodyArg {
        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public CreateWebhookRequestBodyArgTargetField Target { get; set; }

        /// <summary>
        /// The URL that is notified by this webhook
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// An array of event names that this webhook is
        /// to be triggered for
        /// </summary>
        [JsonPropertyName("triggers")]
        public IReadOnlyList<CreateWebhookRequestBodyArgTriggersField> Triggers { get; set; }

        public CreateWebhookRequestBodyArg(CreateWebhookRequestBodyArgTargetField target, string address, IReadOnlyList<CreateWebhookRequestBodyArgTriggersField> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers;
        }
    }
}