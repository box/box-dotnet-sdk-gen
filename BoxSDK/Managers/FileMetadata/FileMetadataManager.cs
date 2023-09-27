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
    public class FileMetadataManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileMetadataManager() {
            
        }
        /// <summary>
        /// Retrieves all metadata for a given file.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getFileMetadata method
        /// </param>
        public async System.Threading.Tasks.Task<Metadatas> GetFileMetadataAsync(string fileId, GetFileMetadataHeadersArg? headers = default) {
            headers = headers ?? new GetFileMetadataHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadatas>(response.Text);
        }

        /// <summary>
        /// Retrieves the instance of a metadata template that has been applied to a
        /// file.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
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
        /// Headers of getFileMetadataById method
        /// </param>
        public async System.Threading.Tasks.Task<MetadataFull> GetFileMetadataByIdAsync(string fileId, GetFileMetadataByIdScopeArg scope, string templateKey, GetFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new GetFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataFull>(response.Text);
        }

        /// <summary>
        /// Applies an instance of a metadata template to a file.
        /// 
        /// In most cases only values that are present in the metadata template
        /// will be accepted, except for the `global.properties` template which accepts
        /// any key-value pair.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
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
        /// Request body of createFileMetadataById method
        /// </param>
        /// <param name="headers">
        /// Headers of createFileMetadataById method
        /// </param>
        public async System.Threading.Tasks.Task<Metadata> CreateFileMetadataByIdAsync(string fileId, CreateFileMetadataByIdScopeArg scope, string templateKey, CreateFileMetadataByIdRequestBodyArg requestBody, CreateFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new CreateFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadata>(response.Text);
        }

        /// <summary>
        /// Updates a piece of metadata on a file.
        /// 
        /// The metadata instance can only be updated if the template has already been
        /// applied to the file before. When editing metadata, only values that match
        /// the metadata template schema will be accepted.
        /// 
        /// The update is applied atomically. If any errors occur during the
        /// application of the operations, the metadata instance will not be changed.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
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
        /// Request body of updateFileMetadataById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFileMetadataById method
        /// </param>
        public async System.Threading.Tasks.Task<Metadata> UpdateFileMetadataByIdAsync(string fileId, UpdateFileMetadataByIdScopeArg scope, string templateKey, IReadOnlyList<UpdateFileMetadataByIdRequestBodyArg> requestBody, UpdateFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Metadata>(response.Text);
        }

        /// <summary>
        /// Deletes a piece of file metadata.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
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
        /// Headers of deleteFileMetadataById method
        /// </param>
        public async System.Threading.Tasks.Task DeleteFileMetadataByIdAsync(string fileId, DeleteFileMetadataByIdScopeArg scope, string templateKey, DeleteFileMetadataByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileMetadataByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/", StringUtils.ToStringRepresentation(scope), "/", StringUtils.ToStringRepresentation(templateKey)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
        }

    }
}