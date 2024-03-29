using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class WebhooksManager : IWebhooksManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public WebhooksManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Returns all defined webhooks for the requesting application.
        /// 
        /// This API only returns webhooks that are applied to files or folders that are
        /// owned by the authenticated user. This means that an admin can not see webhooks
        /// created by a service account unless the admin has access to those folders, and
        /// vice versa.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getWebhooks method
        /// </param>
        /// <param name="headers">
        /// Headers of getWebhooks method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Webhooks> GetWebhooksAsync(GetWebhooksQueryParams? queryParams = default, GetWebhooksHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetWebhooksQueryParams();
            headers = headers ?? new GetWebhooksHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/webhooks"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Webhooks>(response.Data);
        }

        /// <summary>
        /// Creates a webhook.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createWebhook method
        /// </param>
        /// <param name="headers">
        /// Headers of createWebhook method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Webhook> CreateWebhookAsync(CreateWebhookRequestBody requestBody, CreateWebhookHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateWebhookHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/webhooks"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Webhook>(response.Data);
        }

        /// <summary>
        /// Retrieves a specific webhook
        /// </summary>
        /// <param name="webhookId">
        /// The ID of the webhook.
        /// Example: "3321123"
        /// </param>
        /// <param name="headers">
        /// Headers of getWebhookById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Webhook> GetWebhookByIdAsync(string webhookId, GetWebhookByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetWebhookByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/webhooks/", StringUtils.ToStringRepresentation(webhookId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Webhook>(response.Data);
        }

        /// <summary>
        /// Updates a webhook.
        /// </summary>
        /// <param name="webhookId">
        /// The ID of the webhook.
        /// Example: "3321123"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateWebhookById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateWebhookById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Webhook> UpdateWebhookByIdAsync(string webhookId, UpdateWebhookByIdRequestBody? requestBody = default, UpdateWebhookByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateWebhookByIdRequestBody();
            headers = headers ?? new UpdateWebhookByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/webhooks/", StringUtils.ToStringRepresentation(webhookId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Webhook>(response.Data);
        }

        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="webhookId">
        /// The ID of the webhook.
        /// Example: "3321123"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteWebhookById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteWebhookByIdAsync(string webhookId, DeleteWebhookByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteWebhookByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/webhooks/", StringUtils.ToStringRepresentation(webhookId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}