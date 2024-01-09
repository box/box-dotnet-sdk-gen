using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileClassificationsManager : IFileClassificationsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public FileClassificationsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves the classification metadata instance that
        /// has been applied to a file.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/files/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Headers of getClassificationOnFile method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> GetClassificationOnFileAsync(string fileId, GetClassificationOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetClassificationOnFileHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Adds a classification to a file by specifying the label of the
        /// classification to add.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/files/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Request body of addClassificationToFile method
        /// </param>
        /// <param name="headers">
        /// Headers of addClassificationToFile method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> AddClassificationToFileAsync(string fileId, AddClassificationToFileRequestBody? requestBody = default, AddClassificationToFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new AddClassificationToFileRequestBody();
            headers = headers ?? new AddClassificationToFileHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Updates a classification on a file.
        /// 
        /// The classification can only be updated if a classification has already been
        /// applied to the file before. When editing classifications, only values are
        /// defined for the enterprise will be accepted.
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
        /// Request body of updateClassificationOnFile method
        /// </param>
        /// <param name="headers">
        /// Headers of updateClassificationOnFile method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> UpdateClassificationOnFileAsync(string fileId, IReadOnlyList<UpdateClassificationOnFileRequestBody> requestBody, UpdateClassificationOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateClassificationOnFileHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Removes any classifications from a file.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/files/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Headers of deleteClassificationFromFile method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteClassificationFromFileAsync(string fileId, DeleteClassificationFromFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteClassificationFromFileHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}