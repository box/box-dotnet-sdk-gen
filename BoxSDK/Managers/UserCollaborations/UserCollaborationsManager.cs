using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UserCollaborationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public UserCollaborationsManager() {
            
        }
        /// <summary>
        /// Retrieves a single collaboration.
        /// </summary>
        /// <param name="collaborationId">
        /// The ID of the collaboration
        /// Example: "1234"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getCollaborationById method
        /// </param>
        /// <param name="headers">
        /// Headers of getCollaborationById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Collaboration> GetCollaborationByIdAsync(string collaborationId, GetCollaborationByIdQueryParamsArg? queryParams = default, GetCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollaborationByIdQueryParamsArg();
            headers = headers ?? new GetCollaborationByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaborations/", StringUtils.ToStringRepresentation(collaborationId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Collaboration>(response.Data);
        }

        /// <summary>
        /// Updates a collaboration.
        /// Can be used to change the owner of an item, or to
        /// accept collaboration invites.
        /// </summary>
        /// <param name="collaborationId">
        /// The ID of the collaboration
        /// Example: "1234"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateCollaborationById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateCollaborationById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Collaboration> UpdateCollaborationByIdAsync(string collaborationId, UpdateCollaborationByIdRequestBodyArg requestBody, UpdateCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateCollaborationByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaborations/", StringUtils.ToStringRepresentation(collaborationId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Collaboration>(response.Data);
        }

        /// <summary>
        /// Deletes a single collaboration.
        /// </summary>
        /// <param name="collaborationId">
        /// The ID of the collaboration
        /// Example: "1234"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteCollaborationById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteCollaborationByIdAsync(string collaborationId, DeleteCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteCollaborationByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaborations/", StringUtils.ToStringRepresentation(collaborationId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds a collaboration for a single user or a single group to a file
        /// or folder.
        /// 
        /// Collaborations can be created using email address, user IDs, or a
        /// group IDs.
        /// 
        /// If a collaboration is being created with a group, access to
        /// this endpoint is dependent on the group's ability to be invited.
        /// 
        /// If collaboration is in `pending` status, the following fields
        /// are redacted:
        /// - `login` and `name` are hidden if a collaboration was created
        /// using `user_id`,
        /// -  `name` is hidden if a collaboration was created using `login`.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createCollaboration method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of createCollaboration method
        /// </param>
        /// <param name="headers">
        /// Headers of createCollaboration method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Collaboration> CreateCollaborationAsync(CreateCollaborationRequestBodyArg requestBody, CreateCollaborationQueryParamsArg? queryParams = default, CreateCollaborationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new CreateCollaborationQueryParamsArg();
            headers = headers ?? new CreateCollaborationHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "notify", StringUtils.ToStringRepresentation(queryParams.Notify) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collaborations"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Collaboration>(response.Data);
        }

    }
}