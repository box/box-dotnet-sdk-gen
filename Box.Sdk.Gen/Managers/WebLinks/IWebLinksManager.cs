using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IWebLinksManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<WebLink> CreateWebLinkAsync(CreateWebLinkRequestBody requestBody, CreateWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> GetWebLinkByIdAsync(string webLinkId, GetWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkByIdAsync(string webLinkId, UpdateWebLinkByIdRequestBody? requestBody = default, UpdateWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteWebLinkByIdAsync(string webLinkId, DeleteWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}