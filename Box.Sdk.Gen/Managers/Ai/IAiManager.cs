using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

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
    public System.Threading.Tasks.Task<AiResponse> CreateAiAskAsync(AiAsk requestBody, CreateAiAskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Sends an AI request to supported LLMs and returns an answer specifically focused on the creation of new text.
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
    /// Query parameters of getAiAgentDefault method
    /// </param>
    /// <param name="headers">
    /// Headers of getAiAgentDefault method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<AiAgentAskOrAiAgentTextGen> GetAiAgentDefaultAsync(GetAiAgentDefaultQueryParams queryParams, GetAiAgentDefaultHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}