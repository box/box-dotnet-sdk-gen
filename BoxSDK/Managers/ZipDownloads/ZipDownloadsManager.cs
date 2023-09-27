using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using StringExtensions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ZipDownloadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ZipDownloadsManager() {
            
        }
        /// <summary>
        /// Creates a request to download multiple files and folders as a single `zip`
        /// archive file. This API does not return the archive but instead performs all
        /// the checks to ensure that the user has access to all the items, and then
        /// returns a `download_url` and a `status_url` that can be used to download the
        /// archive.
        /// 
        /// The limit for an archive is either the Account's upload limit or
        /// 10,000 files, whichever is met first.
        /// 
        /// **Note**: Downloading a large file can be
        /// affected by various
        /// factors such as distance, network latency,
        /// bandwidth, and congestion, as well as packet loss
        /// ratio and current server load.
        /// For these reasons we recommend that a maximum ZIP archive
        /// total size does not exceed 25GB.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createZipDownload method
        /// </param>
        /// <param name="headers">
        /// Headers of createZipDownload method
        /// </param>
        public async System.Threading.Tasks.Task<ZipDownload> CreateZipDownloadAsync(ZipDownloadRequest requestBody, CreateZipDownloadHeadersArg? headers = default) {
            headers = headers ?? new CreateZipDownloadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/zip_downloads"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ZipDownload>(response.Text);
        }

        /// <summary>
        /// Returns the contents of a `zip` archive in binary format. This URL does not
        /// require any form of authentication and could be used in a user's browser to
        /// download the archive to a user's device.
        /// 
        /// By default, this URL is only valid for a few seconds from the creation of
        /// the request for this archive. Once a download has started it can not be
        /// stopped and resumed, instead a new request for a zip archive would need to
        /// be created.
        /// 
        /// The URL of this endpoint should not be considered as fixed. Instead, use
        /// the [Create zip download](e://post_zip_downloads) API to request to create a
        /// `zip` archive, and then follow the `download_url` field in the response to
        /// this endpoint.
        /// </summary>
        /// <param name="zipDownloadId">
        /// The unique identifier that represent this `zip` archive.
        /// Example: "Lu6fA9Ob-jyysp3AAvMF4AkLEwZwAYbL=tgj2zIC=eK9RvJnJbjJl9rNh2qBgHDpyOCAOhpM=vajg2mKq8Mdd"
        /// </param>
        /// <param name="headers">
        /// Headers of getZipDownloadContent method
        /// </param>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetZipDownloadContentAsync(string zipDownloadId, GetZipDownloadContentHeadersArg? headers = default) {
            headers = headers ?? new GetZipDownloadContentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://dl.boxcloud.com/2.0/zip_downloads/", StringUtils.ToStringRepresentation(zipDownloadId), "/content"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return response.Content;
        }

        /// <summary>
        /// Returns the download status of a `zip` archive, allowing an application to
        /// inspect the progress of the download as well as the number of items that
        /// might have been skipped.
        /// 
        /// This endpoint can only be accessed once the download has started.
        /// Subsequently this endpoint is valid for 12 hours from the start of the
        /// download.
        /// 
        /// The URL of this endpoint should not be considered as fixed. Instead, use
        /// the [Create zip download](e://post_zip_downloads) API to request to create a
        /// `zip` archive, and then follow the `status_url` field in the response to
        /// this endpoint.
        /// </summary>
        /// <param name="zipDownloadId">
        /// The unique identifier that represent this `zip` archive.
        /// Example: "Lu6fA9Ob-jyysp3AAvMF4AkLEwZwAYbL=tgj2zIC=eK9RvJnJbjJl9rNh2qBgHDpyOCAOhpM=vajg2mKq8Mdd"
        /// </param>
        /// <param name="headers">
        /// Headers of getZipDownloadStatus method
        /// </param>
        public async System.Threading.Tasks.Task<ZipDownloadStatus> GetZipDownloadStatusAsync(string zipDownloadId, GetZipDownloadStatusHeadersArg? headers = default) {
            headers = headers ?? new GetZipDownloadStatusHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/zip_downloads/", StringUtils.ToStringRepresentation(zipDownloadId), "/status"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ZipDownloadStatus>(response.Text);
        }

    }
}