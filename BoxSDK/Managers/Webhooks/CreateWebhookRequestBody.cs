using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebhookRequestBody {
        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public CreateWebhookRequestBodyTargetField Target { get; set; }

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
        public IReadOnlyList<CreateWebhookRequestBodyTriggersField> Triggers { get; set; }

        public CreateWebhookRequestBody(CreateWebhookRequestBodyTargetField target, string address, IReadOnlyList<CreateWebhookRequestBodyTriggersField> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers;
        }
    }
}