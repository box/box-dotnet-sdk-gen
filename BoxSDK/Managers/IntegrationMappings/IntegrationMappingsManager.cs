using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class IntegrationMappingsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public IntegrationMappingsManager() {
            
        }
        public async System.Threading.Tasks.Task<IntegrationMappings> GetIntegrationMappingSlack(GetIntegrationMappingSlackQueryParamsArg? queryParams = default, GetIntegrationMappingSlackHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetIntegrationMappingSlackQueryParamsArg();
            headers = headers ?? new GetIntegrationMappingSlackHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "partner_item_type", StringUtils.ToStringRepresentation(queryParams.PartnerItemType) }, { "partner_item_id", StringUtils.ToStringRepresentation(queryParams.PartnerItemId) }, { "box_item_id", StringUtils.ToStringRepresentation(queryParams.BoxItemId) }, { "box_item_type", StringUtils.ToStringRepresentation(queryParams.BoxItemType) }, { "is_manually_created", StringUtils.ToStringRepresentation(queryParams.IsManuallyCreated) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/integration_mappings/slack"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<IntegrationMappings>(response.Text);
        }

        public async System.Threading.Tasks.Task<IntegrationMapping> CreateIntegrationMappingSlack(IntegrationMappingSlackCreateRequest requestBody, CreateIntegrationMappingSlackHeadersArg? headers = default) {
            headers = headers ?? new CreateIntegrationMappingSlackHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/integration_mappings/slack"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<IntegrationMapping>(response.Text);
        }

        public async System.Threading.Tasks.Task<IntegrationMapping> UpdateIntegrationMappingSlackById(string integrationMappingId, UpdateIntegrationMappingSlackByIdRequestBodyArg? requestBody = default, UpdateIntegrationMappingSlackByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateIntegrationMappingSlackByIdRequestBodyArg();
            headers = headers ?? new UpdateIntegrationMappingSlackByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/integration_mappings/slack/", StringUtils.ToStringRepresentation(integrationMappingId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<IntegrationMapping>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteIntegrationMappingSlackById(string integrationMappingId, DeleteIntegrationMappingSlackByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteIntegrationMappingSlackByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/integration_mappings/slack/", StringUtils.ToStringRepresentation(integrationMappingId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}