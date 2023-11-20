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
    public class LegalHoldPolicyAssignmentsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public LegalHoldPolicyAssignmentsManager() {
            
        }
        /// <summary>
        /// Retrieves a list of items a legal hold policy has been assigned to.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getLegalHoldPolicyAssignments method
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicyAssignments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignments> GetLegalHoldPolicyAssignmentsAsync(GetLegalHoldPolicyAssignmentsQueryParamsArg queryParams, GetLegalHoldPolicyAssignmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetLegalHoldPolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "policy_id", StringUtils.ToStringRepresentation(queryParams.PolicyId) }, { "assign_to_type", StringUtils.ToStringRepresentation(queryParams.AssignToType) }, { "assign_to_id", StringUtils.ToStringRepresentation(queryParams.AssignToId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicyAssignments>(response.Data);
        }

        /// <summary>
        /// Assign a legal hold to a file, file version, folder, or user.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createLegalHoldPolicyAssignment method
        /// </param>
        /// <param name="headers">
        /// Headers of createLegalHoldPolicyAssignment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignment> CreateLegalHoldPolicyAssignmentAsync(CreateLegalHoldPolicyAssignmentRequestBodyArg requestBody, CreateLegalHoldPolicyAssignmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateLegalHoldPolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Retrieve a legal hold policy assignment.
        /// </summary>
        /// <param name="legalHoldPolicyAssignmentId">
        /// The ID of the legal hold policy assignment
        /// Example: "753465"
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignment> GetLegalHoldPolicyAssignmentByIdAsync(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetLegalHoldPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<LegalHoldPolicyAssignment>(response.Data);
        }

        /// <summary>
        /// Remove a legal hold from an item.
        /// 
        /// This is an asynchronous process. The policy will not be
        /// fully removed yet when the response returns.
        /// </summary>
        /// <param name="legalHoldPolicyAssignmentId">
        /// The ID of the legal hold policy assignment
        /// Example: "753465"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteLegalHoldPolicyAssignmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteLegalHoldPolicyAssignmentByIdAsync(string legalHoldPolicyAssignmentId, DeleteLegalHoldPolicyAssignmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteLegalHoldPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of current file versions for a legal hold
        /// assignment.
        /// 
        /// In some cases you may want to get previous file versions instead. In these
        /// cases, use the `GET  /legal_hold_policy_assignments/:id/file_versions_on_hold`
        /// API instead to return any previous versions of a file for this legal hold
        /// policy assignment.
        /// 
        /// Due to ongoing re-architecture efforts this API might not return all file
        /// versions held for this policy ID. Instead, this API will only return the
        /// latest file version held in the newly developed architecture. The `GET
        /// /file_version_legal_holds` API can be used to fetch current and past versions
        /// of files held within the legacy architecture.
        /// 
        /// The `GET /legal_hold_policy_assignments?policy_id={id}` API can be used to
        /// find a list of policy assignments for a given policy ID.
        /// </summary>
        /// <param name="legalHoldPolicyAssignmentId">
        /// The ID of the legal hold policy assignment
        /// Example: "753465"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getLegalHoldPolicyAssignmentFileOnHold method
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicyAssignmentFileOnHold method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionLegalHolds> GetLegalHoldPolicyAssignmentFileOnHoldAsync(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentFileOnHoldQueryParamsArg? queryParams = default, GetLegalHoldPolicyAssignmentFileOnHoldHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetLegalHoldPolicyAssignmentFileOnHoldQueryParamsArg();
            headers = headers ?? new GetLegalHoldPolicyAssignmentFileOnHoldHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId), "/files_on_hold"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionLegalHolds>(response.Data);
        }

        /// <summary>
        /// Get a list of previous file versions for a legal hold
        /// assignment.
        /// 
        /// In some cases you may only need the latest file versions instead. In these
        /// cases, use the `GET  /legal_hold_policy_assignments/:id/files_on_hold` API
        /// instead to return any current (latest) versions of a file for this legal hold
        /// policy assignment.
        /// 
        /// Due to ongoing re-architecture efforts this API might not return all files
        /// held for this policy ID. Instead, this API will only return past file versions
        /// held in the newly developed architecture. The `GET /file_version_legal_holds`
        /// API can be used to fetch current and past versions of files held within the
        /// legacy architecture.
        /// 
        /// The `GET /legal_hold_policy_assignments?policy_id={id}` API can be used to
        /// find a list of policy assignments for a given policy ID.
        /// </summary>
        /// <param name="legalHoldPolicyAssignmentId">
        /// The ID of the legal hold policy assignment
        /// Example: "753465"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getLegalHoldPolicyAssignmentFileVersionOnHold method
        /// </param>
        /// <param name="headers">
        /// Headers of getLegalHoldPolicyAssignmentFileVersionOnHold method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionLegalHolds> GetLegalHoldPolicyAssignmentFileVersionOnHoldAsync(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg? queryParams = default, GetLegalHoldPolicyAssignmentFileVersionOnHoldHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg();
            headers = headers ?? new GetLegalHoldPolicyAssignmentFileVersionOnHoldHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId), "/file_versions_on_hold"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionLegalHolds>(response.Data);
        }

    }
}