using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IDownloadsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<System.IO.Stream> DownloadFileAsync(string fileId, DownloadFileQueryParams? queryParams = default, DownloadFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}