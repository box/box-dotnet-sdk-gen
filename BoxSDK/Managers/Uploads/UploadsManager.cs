using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public UploadsManager() {
            
        }
        /// <summary>
        /// Update a file's content. For file sizes over 50MB we recommend
        /// using the Chunk Upload APIs.
        /// 
        /// # Request body order
        /// 
        /// The `attributes` part of the body must come **before** the
        /// `file` part. Requests that do not follow this format when
        /// uploading the file will receive a HTTP `400` error with a
        /// `metadata_after_file_contents` error code.
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
        /// <param name="requestBody">
        /// Request body of uploadFileVersion method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of uploadFileVersion method
        /// </param>
        /// <param name="headers">
        /// Headers of uploadFileVersion method
        /// </param>
        public async System.Threading.Tasks.Task<Files> UploadFileVersionAsync(string fileId, UploadFileVersionRequestBodyArg requestBody, UploadFileVersionQueryParamsArg? queryParams = default, UploadFileVersionHeadersArg? headers = default) {
            queryParams = queryParams ?? new UploadFileVersionQueryParamsArg();
            headers = headers ?? new UploadFileVersionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", StringUtils.ToStringRepresentation(headers.IfMatch) }, { "content-md5", StringUtils.ToStringRepresentation(headers.ContentMd5) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/content"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "attributes", body: SimpleJsonSerializer.Serialize(requestBody.Attributes)),new MultipartItem(partName: "file", fileStream: requestBody.File, fileName: requestBody.FileFileName, contentType: requestBody.FileContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Files>(response.Text);
        }

        /// <summary>
        /// Uploads a small file to Box. For file sizes over 50MB we recommend
        /// using the Chunk Upload APIs.
        /// 
        /// # Request body order
        /// 
        /// The `attributes` part of the body must come **before** the
        /// `file` part. Requests that do not follow this format when
        /// uploading the file will receive a HTTP `400` error with a
        /// `metadata_after_file_contents` error code.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of uploadFile method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of uploadFile method
        /// </param>
        /// <param name="headers">
        /// Headers of uploadFile method
        /// </param>
        public async System.Threading.Tasks.Task<Files> UploadFileAsync(UploadFileRequestBodyArg requestBody, UploadFileQueryParamsArg? queryParams = default, UploadFileHeadersArg? headers = default) {
            queryParams = queryParams ?? new UploadFileQueryParamsArg();
            headers = headers ?? new UploadFileHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "content-md5", StringUtils.ToStringRepresentation(headers.ContentMd5) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/content"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "attributes", body: SimpleJsonSerializer.Serialize(requestBody.Attributes)),new MultipartItem(partName: "file", fileStream: requestBody.File, fileName: requestBody.FileFileName, contentType: requestBody.FileContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Files>(response.Text);
        }

        /// <summary>
        /// Performs a check to verify that a file will be accepted by Box
        /// before you upload the entire file.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of preflightFileUpload method
        /// </param>
        /// <param name="headers">
        /// Headers of preflightFileUpload method
        /// </param>
        public async System.Threading.Tasks.Task<UploadUrl> PreflightFileUploadAsync(PreflightFileUploadRequestBodyArg? requestBody = default, PreflightFileUploadHeadersArg? headers = default) {
            requestBody = requestBody ?? new PreflightFileUploadRequestBodyArg();
            headers = headers ?? new PreflightFileUploadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/content"), new FetchOptions(method: "OPTIONS", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadUrl>(response.Text);
        }

    }
}