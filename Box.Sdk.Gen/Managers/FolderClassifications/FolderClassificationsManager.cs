using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class FolderClassificationsManager : IFolderClassificationsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public FolderClassificationsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves the classification metadata instance that
        /// has been applied to a folder.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/folders/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Headers of getClassificationOnFolder method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> GetClassificationOnFolderAsync(string folderId, GetClassificationOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetClassificationOnFolderHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Adds a classification to a folder by specifying the label of the
        /// classification to add.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/folders/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Request body of addClassificationToFolder method
        /// </param>
        /// <param name="headers">
        /// Headers of addClassificationToFolder method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> AddClassificationToFolderAsync(string folderId, AddClassificationToFolderRequestBody? requestBody = default, AddClassificationToFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new AddClassificationToFolderRequestBody();
            headers = headers ?? new AddClassificationToFolderHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Updates a classification on a folder.
        /// 
        /// The classification can only be updated if a classification has already been
        /// applied to the folder before. When editing classifications, only values are
        /// defined for the enterprise will be accepted.
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
        /// Request body of updateClassificationOnFolder method
        /// </param>
        /// <param name="headers">
        /// Headers of updateClassificationOnFolder method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Classification> UpdateClassificationOnFolderAsync(string folderId, IReadOnlyList<UpdateClassificationOnFolderRequestBody> requestBody, UpdateClassificationOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateClassificationOnFolderHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Classification>(response.Data);
        }

        /// <summary>
        /// Removes any classifications from a folder.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/folders/:id//enterprise_12345/securityClassification-6VMVochwUWo`.
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
        /// Headers of deleteClassificationFromFolder method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteClassificationFromFolderAsync(string folderId, DeleteClassificationFromFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteClassificationFromFolderHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/folders/", StringUtils.ToStringRepresentation(folderId), "/metadata/enterprise/securityClassification-6VMVochwUWo"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}