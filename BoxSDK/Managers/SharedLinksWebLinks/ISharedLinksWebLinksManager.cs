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

        public System.Threading.Tasks.Task<WebLink> FindWebLinkForSharedLinkAsync(FindWebLinkForSharedLinkHeaders headers, FindWebLinkForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> GetSharedLinkForWebLinkAsync(string webLinkId, GetSharedLinkForWebLinkQueryParams queryParams, GetSharedLinkForWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> AddShareLinkToWebLinkAsync(string webLinkId, AddShareLinkToWebLinkQueryParams queryParams, AddShareLinkToWebLinkRequestBody? requestBody = default, AddShareLinkToWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateSharedLinkOnWebLinkAsync(string webLinkId, UpdateSharedLinkOnWebLinkQueryParams queryParams, UpdateSharedLinkOnWebLinkRequestBody? requestBody = default, UpdateSharedLinkOnWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> RemoveSharedLinkFromWebLinkAsync(string webLinkId, RemoveSharedLinkFromWebLinkQueryParams queryParams, RemoveSharedLinkFromWebLinkRequestBody? requestBody = default, RemoveSharedLinkFromWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}