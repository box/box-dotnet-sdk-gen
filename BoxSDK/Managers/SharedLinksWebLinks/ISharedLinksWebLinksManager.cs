using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISharedLinksWebLinksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinksAsync(GetSharedItemWebLinksHeadersArg headers, GetSharedItemWebLinksQueryParamsArg? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLinkAsync(string webLinkId, GetWebLinkGetSharedLinkQueryParamsArg queryParams, GetWebLinkGetSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLinkAsync(string webLinkId, UpdateWebLinkAddSharedLinkQueryParamsArg queryParams, UpdateWebLinkAddSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkAddSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLinkAsync(string webLinkId, UpdateWebLinkUpdateSharedLinkQueryParamsArg queryParams, UpdateWebLinkUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkUpdateSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLinkAsync(string webLinkId, UpdateWebLinkRemoveSharedLinkQueryParamsArg queryParams, UpdateWebLinkRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateWebLinkRemoveSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}