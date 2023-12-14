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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<WebLink> GetSharedItemWebLinksAsync(GetSharedItemWebLinksHeaders headers, GetSharedItemWebLinksQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> GetWebLinkGetSharedLinkAsync(string webLinkId, GetWebLinkGetSharedLinkQueryParams queryParams, GetWebLinkGetSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkAddSharedLinkAsync(string webLinkId, UpdateWebLinkAddSharedLinkQueryParams queryParams, UpdateWebLinkAddSharedLinkRequestBody? requestBody = default, UpdateWebLinkAddSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkUpdateSharedLinkAsync(string webLinkId, UpdateWebLinkUpdateSharedLinkQueryParams queryParams, UpdateWebLinkUpdateSharedLinkRequestBody? requestBody = default, UpdateWebLinkUpdateSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkRemoveSharedLinkAsync(string webLinkId, UpdateWebLinkRemoveSharedLinkQueryParams queryParams, UpdateWebLinkRemoveSharedLinkRequestBody? requestBody = default, UpdateWebLinkRemoveSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}