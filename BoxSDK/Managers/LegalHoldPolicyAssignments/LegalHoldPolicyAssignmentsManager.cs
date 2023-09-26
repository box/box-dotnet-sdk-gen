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
        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignments> GetLegalHoldPolicyAssignments(GetLegalHoldPolicyAssignmentsQueryParamsArg queryParams, GetLegalHoldPolicyAssignmentsHeadersArg? headers = default) {
            headers = headers ?? new GetLegalHoldPolicyAssignmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "policy_id", StringUtils.ToStringRepresentation(queryParams.PolicyId) }, { "assign_to_type", StringUtils.ToStringRepresentation(queryParams.AssignToType) }, { "assign_to_id", StringUtils.ToStringRepresentation(queryParams.AssignToId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicyAssignments>(response.Text);
        }

        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignment> CreateLegalHoldPolicyAssignment(CreateLegalHoldPolicyAssignmentRequestBodyArg requestBody, CreateLegalHoldPolicyAssignmentHeadersArg? headers = default) {
            headers = headers ?? new CreateLegalHoldPolicyAssignmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task<LegalHoldPolicyAssignment> GetLegalHoldPolicyAssignmentById(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new GetLegalHoldPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<LegalHoldPolicyAssignment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteLegalHoldPolicyAssignmentById(string legalHoldPolicyAssignmentId, DeleteLegalHoldPolicyAssignmentByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteLegalHoldPolicyAssignmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<FileVersionLegalHolds> GetLegalHoldPolicyAssignmentFileOnHold(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentFileOnHoldQueryParamsArg? queryParams = default, GetLegalHoldPolicyAssignmentFileOnHoldHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetLegalHoldPolicyAssignmentFileOnHoldQueryParamsArg();
            headers = headers ?? new GetLegalHoldPolicyAssignmentFileOnHoldHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId), "/files_on_hold"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionLegalHolds>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileVersionLegalHolds> GetLegalHoldPolicyAssignmentFileVersionOnHold(string legalHoldPolicyAssignmentId, GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg? queryParams = default, GetLegalHoldPolicyAssignmentFileVersionOnHoldHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg();
            headers = headers ?? new GetLegalHoldPolicyAssignmentFileVersionOnHoldHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/legal_hold_policy_assignments/", StringUtils.ToStringRepresentation(legalHoldPolicyAssignmentId), "/file_versions_on_hold"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionLegalHolds>(response.Text);
        }

    }
}