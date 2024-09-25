using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IIntegrationMappingsManager {
        /// <summary>
    /// Lists [Slack integration mappings](https://support.box.com/hc/en-us/articles/4415585987859-Box-as-the-Content-Layer-for-Slack) in a users' enterprise.
    /// 
    /// You need Admin or Co-Admin role to
    /// use this endpoint.
    /// </summary>
    /// <param name="queryParams">
    /// Query parameters of getSlackIntegrationMapping method
    /// </param>
    /// <param name="headers">
    /// Headers of getSlackIntegrationMapping method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<IntegrationMappings> GetSlackIntegrationMappingAsync(GetSlackIntegrationMappingQueryParams? queryParams = default, GetSlackIntegrationMappingHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Creates a [Slack integration mapping](https://support.box.com/hc/en-us/articles/4415585987859-Box-as-the-Content-Layer-for-Slack)
    /// by mapping a Slack channel to a Box item.
    /// 
    /// You need Admin or Co-Admin role to
    /// use this endpoint.
    /// </summary>
    /// <param name="requestBody">
    /// Request body of createSlackIntegrationMapping method
    /// </param>
    /// <param name="headers">
    /// Headers of createSlackIntegrationMapping method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<IntegrationMapping> CreateSlackIntegrationMappingAsync(IntegrationMappingSlackCreateRequest requestBody, CreateSlackIntegrationMappingHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Updates a [Slack integration mapping](https://support.box.com/hc/en-us/articles/4415585987859-Box-as-the-Content-Layer-for-Slack).
    /// Supports updating the Box folder ID and options.
    /// 
    /// You need Admin or Co-Admin role to
    /// use this endpoint.
    /// </summary>
    /// <param name="integrationMappingId">
    /// An ID of an integration mapping
    /// Example: "11235432"
    /// </param>
    /// <param name="requestBody">
    /// Request body of updateSlackIntegrationMappingById method
    /// </param>
    /// <param name="headers">
    /// Headers of updateSlackIntegrationMappingById method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<IntegrationMapping> UpdateSlackIntegrationMappingByIdAsync(string integrationMappingId, UpdateSlackIntegrationMappingByIdRequestBody? requestBody = default, UpdateSlackIntegrationMappingByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Deletes a [Slack integration mapping](https://support.box.com/hc/en-us/articles/4415585987859-Box-as-the-Content-Layer-for-Slack).
    /// 
    /// 
    /// You need Admin or Co-Admin role to
    /// use this endpoint.
    /// </summary>
    /// <param name="integrationMappingId">
    /// An ID of an integration mapping
    /// Example: "11235432"
    /// </param>
    /// <param name="headers">
    /// Headers of deleteSlackIntegrationMappingById method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task DeleteSlackIntegrationMappingByIdAsync(string integrationMappingId, DeleteSlackIntegrationMappingByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}