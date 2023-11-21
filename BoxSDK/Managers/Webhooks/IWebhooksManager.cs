using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IWebhooksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Webhooks> GetWebhooksAsync(GetWebhooksQueryParamsArg? queryParams = default, GetWebhooksHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Webhook> CreateWebhookAsync(CreateWebhookRequestBodyArg requestBody, CreateWebhookHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Webhook> GetWebhookByIdAsync(string webhookId, GetWebhookByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Webhook> UpdateWebhookByIdAsync(string webhookId, UpdateWebhookByIdRequestBodyArg? requestBody = default, UpdateWebhookByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteWebhookByIdAsync(string webhookId, DeleteWebhookByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}