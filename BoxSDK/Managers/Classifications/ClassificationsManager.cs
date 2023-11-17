using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ClassificationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ClassificationsManager() {
            
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
        /// Headers of getMetadataTemplateEnterpriseSecurityClassificationSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> GetMetadataTemplateEnterpriseSecurityClassificationSchemaAsync(GetMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

        /// <summary>
        /// Delete all classifications by deleting the classification
        /// metadata template.
        /// </summary>
        /// <param name="headers">
        /// Headers of deleteMetadataTemplateEnterpriseSecurityClassificationSchema method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteMetadataTemplateEnterpriseSecurityClassificationSchemaAsync(DeleteMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteMetadataTemplateEnterpriseSecurityClassificationSchemaHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        /// Request body of updateMetadataTemplateEnterpriseSecurityClassificationSchemaAdd method
        /// </param>
        /// <param name="headers">
        /// Headers of updateMetadataTemplateEnterpriseSecurityClassificationSchemaAdd method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddAsync(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaAddHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#add"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        /// Request body of updateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdate method
        /// </param>
        /// <param name="headers">
        /// Headers of updateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdate method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateAsync(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaUpdateHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#update"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

        /// <summary>
        /// Removes a classification from the list of classifications
        /// available to the enterprise.
        /// 
        /// This API can also be called by including the enterprise ID in the
        /// URL explicitly, for example
        /// `/metadata_templates/enterprise_12345/securityClassification-6VMVochwUWo/schema`.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of updateMetadataTemplateEnterpriseSecurityClassificationSchemaDelete method
        /// </param>
        /// <param name="headers">
        /// Headers of updateMetadataTemplateEnterpriseSecurityClassificationSchemaDelete method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteAsync(IReadOnlyList<UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteRequestBodyArg> requestBody, UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema#delete"), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
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
        /// Request body of createMetadataTemplateSchemaClassification method
        /// </param>
        /// <param name="headers">
        /// Headers of createMetadataTemplateSchemaClassification method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ClassificationTemplate> CreateMetadataTemplateSchemaClassificationAsync(CreateMetadataTemplateSchemaClassificationRequestBodyArg requestBody, CreateMetadataTemplateSchemaClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateMetadataTemplateSchemaClassificationHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_templates/schema#classifications"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ClassificationTemplate>(response.Data);
        }

    }
}