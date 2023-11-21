using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IZipDownloadsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<ZipDownload> CreateZipDownloadAsync(ZipDownloadRequest requestBody, CreateZipDownloadHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<System.IO.Stream> GetZipDownloadContentAsync(string downloadUrl, GetZipDownloadContentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ZipDownloadStatus> GetZipDownloadStatusAsync(string statusUrl, GetZipDownloadStatusHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<System.IO.Stream> DownloadZipAsync(ZipDownloadRequest requestBody, DownloadZipHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}