using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SignTemplatesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SignTemplatesManager() {
            
        }
        public async System.Threading.Tasks.Task<SignTemplates> GetSignTemplates(GetSignTemplatesQueryParamsArg? queryParams = default, GetSignTemplatesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetSignTemplatesQueryParamsArg();
            headers = headers ?? new GetSignTemplatesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_templates"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignTemplates>(response.Text);
        }

        public async System.Threading.Tasks.Task<SignTemplate> GetSignTemplateById(string templateId, GetSignTemplateByIdHeadersArg? headers = default) {
            headers = headers ?? new GetSignTemplateByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_templates/", StringUtils.ToStringRepresentation(templateId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignTemplate>(response.Text);
        }

    }
}