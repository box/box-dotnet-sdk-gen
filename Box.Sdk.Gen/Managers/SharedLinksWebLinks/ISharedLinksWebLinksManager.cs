using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ISharedLinksWebLinksManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<WebLink> FindWebLinkForSharedLinkAsync(FindWebLinkForSharedLinkHeaders headers, FindWebLinkForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<WebLink> GetSharedLinkForWebLinkAsync(string webLinkId, GetSharedLinkForWebLinkQueryParams queryParams, GetSharedLinkForWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<WebLink> AddShareLinkToWebLinkAsync(string webLinkId, AddShareLinkToWebLinkQueryParams queryParams, AddShareLinkToWebLinkRequestBody? requestBody = default, AddShareLinkToWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<WebLink> UpdateSharedLinkOnWebLinkAsync(string webLinkId, UpdateSharedLinkOnWebLinkQueryParams queryParams, UpdateSharedLinkOnWebLinkRequestBody? requestBody = default, UpdateSharedLinkOnWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<WebLink> RemoveSharedLinkFromWebLinkAsync(string webLinkId, RemoveSharedLinkFromWebLinkQueryParams queryParams, RemoveSharedLinkFromWebLinkRequestBody? requestBody = default, RemoveSharedLinkFromWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}