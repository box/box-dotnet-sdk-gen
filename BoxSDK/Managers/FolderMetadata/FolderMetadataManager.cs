using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FolderMetadataManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FolderMetadataManager() {
            
        }
        /// <summary>
        /// Retrieves all metadata for a given folder. This can not be used on the root
        /// folder with ID `0`.
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
        /// Headers of getFolderMetadata method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Metadatas> GetFolderMetadataAsync(string folderId, GetFolderMetadataHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFolderMetadataHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadatas>(response.Data);
        }

        /// <summary>
        /// Retrieves the instance of a metadata template that has been applied to a
        /// folder. This can not be used on the root folder with ID `0`.
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
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="headers">
        /// Headers of getFolderMetadataById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<MetadataFull> GetFolderMetadataByIdAsync(string folderId, GetFolderMetadataByIdScopeArg scope, string templateKey, GetFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataFull>(response.Data);
        }

        /// <summary>
        /// Applies an instance of a metadata template to a folder.
        /// 
        /// In most cases only values that are present in the metadata template
        /// will be accepted, except for the `global.properties` template which accepts
        /// any key-value pair.
        /// 
        /// To display the metadata template in the Box web app the enterprise needs to be
        /// configured to enable **Cascading Folder Level Metadata** for the user in the
        /// admin console.
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
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createFolderMetadataById method
        /// </param>
        /// <param name="headers">
        /// Headers of createFolderMetadataById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Metadata> CreateFolderMetadataByIdAsync(string folderId, CreateFolderMetadataByIdScopeArg scope, string templateKey, CreateFolderMetadataByIdRequestBodyArg requestBody, CreateFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadata>(response.Data);
        }

        /// <summary>
        /// Updates a piece of metadata on a folder.
        /// 
        /// The metadata instance can only be updated if the template has already been
        /// applied to the folder before. When editing metadata, only values that match
        /// the metadata template schema will be accepted.
        /// 
        /// The update is applied atomically. If any errors occur during the
        /// application of the operations, the metadata instance will not be changed.
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
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFolderMetadataById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFolderMetadataById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Metadata> UpdateFolderMetadataByIdAsync(string folderId, UpdateFolderMetadataByIdScopeArg scope, string templateKey, IReadOnlyList<UpdateFolderMetadataByIdRequestBodyArg> requestBody, UpdateFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadata>(response.Data);
        }

        /// <summary>
        /// Deletes a piece of folder metadata.
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
        /// <param name="scope">
        /// The scope of the metadata template
        /// Example: "global"
        /// </param>
        /// <param name="templateKey">
        /// The name of the metadata template
        /// Example: "properties"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFolderMetadataById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFolderMetadataByIdAsync(string folderId, DeleteFolderMetadataByIdScopeArg scope, string templateKey, DeleteFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFolderMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}