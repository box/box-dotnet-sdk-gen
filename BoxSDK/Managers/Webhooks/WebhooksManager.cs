using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class WebhooksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public WebhooksManager() {
            
        }
        public async System.Threading.Tasks.Task<Webhooks> GetWebhooks(GetWebhooksQueryParamsArg? queryParams = default, GetWebhooksHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetWebhooksQueryParamsArg();
            headers = headers ?? new GetWebhooksHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/webhooks"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Webhooks>(response.Text);
        }

        public async System.Threading.Tasks.Task<Webhook> CreateWebhook(CreateWebhookRequestBodyArg requestBody, CreateWebhookHeadersArg? headers = default) {
            headers = headers ?? new CreateWebhookHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/webhooks"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Webhook>(response.Text);
        }

        public async System.Threading.Tasks.Task<Webhook> GetWebhookById(string webhookId, GetWebhookByIdHeadersArg? headers = default) {
            headers = headers ?? new GetWebhookByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/webhooks/", webhookId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Webhook>(response.Text);
        }

        public async System.Threading.Tasks.Task<Webhook> UpdateWebhookById(string webhookId, UpdateWebhookByIdRequestBodyArg? requestBody = default, UpdateWebhookByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateWebhookByIdRequestBodyArg();
            headers = headers ?? new UpdateWebhookByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/webhooks/", webhookId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Webhook>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteWebhookById(string webhookId, DeleteWebhookByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteWebhookByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/webhooks/", webhookId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}