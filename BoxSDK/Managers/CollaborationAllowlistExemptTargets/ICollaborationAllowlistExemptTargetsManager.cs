using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ICollaborationAllowlistExemptTargetsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTargets> GetCollaborationWhitelistExemptTargetsAsync(GetCollaborationWhitelistExemptTargetsQueryParamsArg? queryParams = default, GetCollaborationWhitelistExemptTargetsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> CreateCollaborationWhitelistExemptTargetAsync(CreateCollaborationWhitelistExemptTargetRequestBodyArg requestBody, CreateCollaborationWhitelistExemptTargetHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> GetCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, GetCollaborationWhitelistExemptTargetByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, DeleteCollaborationWhitelistExemptTargetByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}