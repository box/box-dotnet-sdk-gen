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
        /// <summary>
        /// Gets Box Sign templates created by a user.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getSignTemplates method
        /// </param>
        /// <param name="headers">
        /// Headers of getSignTemplates method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignTemplates> GetSignTemplatesAsync(GetSignTemplatesQueryParamsArg? queryParams = default, GetSignTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetSignTemplatesQueryParamsArg();
            headers = headers ?? new GetSignTemplatesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_templates"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignTemplates>(response.Data);
        }

        /// <summary>
        /// Fetches details of a specific Box Sign template.
        /// </summary>
        /// <param name="templateId">
        /// The ID of a Box Sign template.
        /// Example: "123075213-7d117509-8f05-42e4-a5ef-5190a319d41d"
        /// </param>
        /// <param name="headers">
        /// Headers of getSignTemplateById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignTemplate> GetSignTemplateByIdAsync(string templateId, GetSignTemplateByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetSignTemplateByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_templates/", StringUtils.ToStringRepresentation(templateId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignTemplate>(response.Data);
        }

    }
}