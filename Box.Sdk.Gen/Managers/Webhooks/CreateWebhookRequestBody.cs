using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Linq;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateWebhookRequestBody {
        /// <summary>
        /// The item that will trigger the webhook
        /// </summary>
        [JsonPropertyName("target")]
        public CreateWebhookRequestBodyTargetField Target { get; }

        /// <summary>
        /// The URL that is notified by this webhook
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; }

        /// <summary>
        /// An array of event names that this webhook is
        /// to be triggered for
        /// </summary>
        [JsonPropertyName("triggers")]
        [JsonConverter(typeof(StringEnumListConverter<CreateWebhookRequestBodyTriggersField>))]
        public IReadOnlyList<StringEnum<CreateWebhookRequestBodyTriggersField>> Triggers { get; }

        public CreateWebhookRequestBody(CreateWebhookRequestBodyTargetField target, string address, IReadOnlyList<CreateWebhookRequestBodyTriggersField> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers.Select(x => new StringEnum<CreateWebhookRequestBodyTriggersField>(x)).ToList();
        }
        
        [JsonConstructorAttribute]
        internal CreateWebhookRequestBody(CreateWebhookRequestBodyTargetField target, string address, IReadOnlyList<StringEnum<CreateWebhookRequestBodyTriggersField>> triggers) {
            Target = target;
            Address = address;
            Triggers = triggers;
        }
    }
}