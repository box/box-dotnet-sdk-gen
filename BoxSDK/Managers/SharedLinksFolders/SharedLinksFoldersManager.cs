using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SharedLinksFoldersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SharedLinksFoldersManager() {
            
        }
        /// <summary>
        /// Return the folder represented by a shared link.
        /// 
        /// A shared folder can be represented by a shared link,
        /// which can originate within the current enterprise or within another.
        /// 
        /// This endpoint allows an application to retrieve information about a
        /// shared folder when only given a shared link.
        /// </summary>
        /// <param name="headers">
        /// Headers of getSharedItemFolders method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getSharedItemFolders method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> GetSharedItemFoldersAsync(GetSharedItemFoldersHeadersArg headers, GetSharedItemFoldersQueryParamsArg? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetSharedItemFoldersQueryParamsArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shared_items#folders"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Text);
        }

        /// <summary>
        /// Gets the information for a shared link on a folder.
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
        /// <param name="queryParams">
        /// Query parameters of getFolderGetSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of getFolderGetSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> GetFolderGetSharedLinkAsync(string folderId, GetFolderGetSharedLinkQueryParamsArg queryParams, GetFolderGetSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFolderGetSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Text);
        }

        /// <summary>
        /// Adds a shared link to a folder.
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
        /// <param name="queryParams">
        /// Query parameters of updateFolderAddSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFolderAddSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFolderAddSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderAddSharedLinkAsync(string folderId, UpdateFolderAddSharedLinkQueryParamsArg queryParams, UpdateFolderAddSharedLinkRequestBodyArg? requestBody = default, UpdateFolderAddSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateFolderAddSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderAddSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Text);
        }

        /// <summary>
        /// Updates a shared link on a folder.
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
        /// <param name="queryParams">
        /// Query parameters of updateFolderUpdateSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFolderUpdateSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFolderUpdateSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderUpdateSharedLinkAsync(string folderId, UpdateFolderUpdateSharedLinkQueryParamsArg queryParams, UpdateFolderUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateFolderUpdateSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateFolderUpdateSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderUpdateSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Text);
        }

        /// <summary>
        /// Removes a shared link from a folder.
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
        /// <param name="queryParams">
        /// Query parameters of updateFolderRemoveSharedLink method
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFolderRemoveSharedLink method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFolderRemoveSharedLink method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> UpdateFolderRemoveSharedLinkAsync(string folderId, UpdateFolderRemoveSharedLinkQueryParamsArg queryParams, UpdateFolderRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateFolderRemoveSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateFolderRemoveSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFolderRemoveSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Text);
        }

    }
}