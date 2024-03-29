using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class ClassificationsManager : IClassificationsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public ClassificationsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves the classification metadata template and lists all the
        /// classifications available to this enterprise.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/metadata_templates/enterprise_12345/securityClassification-6VMVochwUWo/schema`.
        /// </summary>
        /// <param name="headers">
        /// Headers of getClassificationTemplate method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> GetClassificationTemplateAsync(GetClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetClassificationTemplateHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

        /// <summary>
        /// Adds one or more new classifications to the list of classifications
        /// available to the enterprise.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/metadata_templates/enterprise_12345/securityClassification-6VMVochwUWo/schema`.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of addClassification method
        /// </param>
        /// <param name="headers">
        /// Headers of addClassification method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> AddClassificationAsync(IReadOnlyList<AddClassificationRequestBody> requestBody, AddClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new AddClassificationHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#add"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

        /// <summary>
        /// Updates the labels and descriptions of one or more classifications
        /// available to the enterprise.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/metadata_templates/enterprise_12345/securityClassification-6VMVochwUWo/schema`.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of updateClassification method
        /// </param>
        /// <param name="headers">
        /// Headers of updateClassification method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateClassificationAsync(IReadOnlyList<UpdateClassificationRequestBody> requestBody, UpdateClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateClassificationHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#update"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

        /// <summary>
        /// When an enterprise does not yet have any classifications, this API call
        /// initializes the classification template with an initial set of
        /// classifications.
        /// 
        /// If an enterprise already has a classification, the template will already
        /// exist and instead an API call should be made to add additional
        /// classifications.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createClassificationTemplate method
        /// </param>
        /// <param name="headers">
        /// Headers of createClassificationTemplate method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> CreateClassificationTemplateAsync(CreateClassificationTemplateRequestBody requestBody, CreateClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateClassificationTemplateHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/metadata_templates/schema#classifications"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

    }
}