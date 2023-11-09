using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FolderWatermarksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FolderWatermarksManager() {
            
        }
        /// <summary>
        /// Retrieve the watermark for a folder.
        /// </summary>
        /// <param name="folderId">
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting this folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folder/123`
        /// the `folder_id` is `123`.
        /// 
        /// The root folder of a Box account is
        /// always represented by the ID `0`.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getFolderWatermark method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Watermark> GetFolderWatermarkAsync(string folderId, GetFolderWatermarkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFolderWatermarkHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/watermark"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Watermark>(response.Data);
        }

        /// <summary>
        /// Applies or update a watermark on a folder.
        /// </summary>
        /// <param name="folderId">
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting this folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folder/123`
        /// the `folder_id` is `123`.
        /// 
        /// The root folder of a Box account is
        /// always represented by the ID `0`.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFolderWatermark method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFolderWatermark method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Watermark> UpdateFolderWatermarkAsync(string folderId, UpdateFolderWatermarkRequestBodyArg requestBody, UpdateFolderWatermarkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateFolderWatermarkHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/watermark"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Watermark>(response.Data);
        }

        /// <summary>
        /// Removes the watermark from a folder.
        /// </summary>
        /// <param name="folderId">
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting this folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folder/123`
        /// the `folder_id` is `123`.
        /// 
        /// The root folder of a Box account is
        /// always represented by the ID `0`.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFolderWatermark method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFolderWatermarkAsync(string folderId, DeleteFolderWatermarkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFolderWatermarkHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/watermark"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}