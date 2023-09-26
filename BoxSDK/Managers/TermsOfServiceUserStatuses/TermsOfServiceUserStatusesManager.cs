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
    public class TermsOfServiceUserStatusesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TermsOfServiceUserStatusesManager() {
            
        }
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermOfServiceUserStatuses(GetTermOfServiceUserStatusesQueryParamsArg queryParams, GetTermOfServiceUserStatusesHeadersArg? headers = default) {
            headers = headers ?? new GetTermOfServiceUserStatusesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "tos_id", StringUtils.ToStringRepresentation(queryParams.TosId) }, { "user_id", StringUtils.ToStringRepresentation(queryParams.UserId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfServiceUserStatuses>(response.Text);
        }

        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermOfServiceUserStatus(CreateTermOfServiceUserStatusRequestBodyArg requestBody, CreateTermOfServiceUserStatusHeadersArg? headers = default) {
            headers = headers ?? new CreateTermOfServiceUserStatusHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfServiceUserStatus>(response.Text);
        }

        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermOfServiceUserStatusById(string termsOfServiceUserStatusId, UpdateTermOfServiceUserStatusByIdRequestBodyArg requestBody, UpdateTermOfServiceUserStatusByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateTermOfServiceUserStatusByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses/", StringUtils.ToStringRepresentation(termsOfServiceUserStatusId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfServiceUserStatus>(response.Text);
        }

    }
}