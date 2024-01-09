using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IWebLinksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<WebLink> CreateWebLinkAsync(CreateWebLinkRequestBody requestBody, CreateWebLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> GetWebLinkByIdAsync(string webLinkId, GetWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<WebLink> UpdateWebLinkByIdAsync(string webLinkId, UpdateWebLinkByIdRequestBody? requestBody = default, UpdateWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteWebLinkByIdAsync(string webLinkId, DeleteWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}