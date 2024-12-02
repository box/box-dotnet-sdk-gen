using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IAiManager {
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
    public System.Threading.Tasks.Task<AiResponseFull> CreateAiAskAsync(AiAsk requestBody, CreateAiAskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

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
    public System.Threading.Tasks.Task<AiResponse> CreateAiTextGenAsync(AiTextGen requestBody, CreateAiTextGenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

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
    public System.Threading.Tasks.Task<AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen> GetAiAgentDefaultConfigAsync(GetAiAgentDefaultConfigQueryParams queryParams, GetAiAgentDefaultConfigHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

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
    public System.Threading.Tasks.Task<AiResponse> CreateAiExtractAsync(AiExtract requestBody, CreateAiExtractHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

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
    public System.Threading.Tasks.Task<AiExtractResponse> CreateAiExtractStructuredAsync(AiExtractStructured requestBody, CreateAiExtractStructuredHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}