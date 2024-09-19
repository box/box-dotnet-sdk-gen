using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class AiManager : IAiManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public AiManager(NetworkSession? networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Sends an AI request to supported LLMs and returns an answer specifically focused on the user's question given the provided context.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createAiAsk method
        /// </param>
        /// <param name="headers">
        /// Headers of createAiAsk method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AiResponseFull> CreateAiAskAsync(AiAsk requestBody, CreateAiAskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateAiAskHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/ai/ask"), networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AiResponseFull>(response.Data);
        }

        /// <summary>
        /// Sends an AI request to supported Large Language Models (LLMs) and returns generated text based on the provided prompt.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createAiTextGen method
        /// </param>
        /// <param name="headers">
        /// Headers of createAiTextGen method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AiResponse> CreateAiTextGenAsync(AiTextGen requestBody, CreateAiTextGenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateAiTextGenHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/ai/text_gen"), networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AiResponse>(response.Data);
        }

        /// <summary>
        /// Get the AI agent default config
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getAiAgentDefaultConfig method
        /// </param>
        /// <param name="headers">
        /// Headers of getAiAgentDefaultConfig method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen> GetAiAgentDefaultConfigAsync(GetAiAgentDefaultConfigQueryParams queryParams, GetAiAgentDefaultConfigHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetAiAgentDefaultConfigHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "mode", StringUtils.ToStringRepresentation(queryParams.Mode?.Value) }, { "language", StringUtils.ToStringRepresentation(queryParams.Language) }, { "model", StringUtils.ToStringRepresentation(queryParams.Model) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/ai_agent_default"), networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.DeserializeWithoutRawJson<AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen>(response.Data);
        }

        /// <summary>
        /// Sends an AI request to supported Large Language Models (LLMs) and extracts metadata in form of key-value pairs.
        /// Freeform metadata extraction does not require any metadata template setup before sending the request.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createAiExtract method
        /// </param>
        /// <param name="headers">
        /// Headers of createAiExtract method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AiResponse> CreateAiExtractAsync(AiExtract requestBody, CreateAiExtractHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateAiExtractHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/ai/extract"), networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AiResponse>(response.Data);
        }

        /// <summary>
        /// Sends an AI request to supported Large Language Models (LLMs) and returns extracted metadata as a set of key-value pairs.
        /// For this request, you need to use an already defined metadata template or a define a schema yourself.
        /// To learn more about creating templates, see [Creating metadata templates in the Admin Console](https://support.box.com/hc/en-us/articles/360044194033-Customizing-Metadata-Templates)
        /// or use the [metadata template API](g://metadata/templates/create).
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createAiExtractStructured method
        /// </param>
        /// <param name="headers">
        /// Headers of createAiExtractStructured method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<AiExtractResponse> CreateAiExtractStructuredAsync(AiExtractStructured requestBody, CreateAiExtractStructuredHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateAiExtractStructuredHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(new FetchOptions(url: string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/ai/extract_structured"), networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<AiExtractResponse>(response.Data);
        }

    }
}