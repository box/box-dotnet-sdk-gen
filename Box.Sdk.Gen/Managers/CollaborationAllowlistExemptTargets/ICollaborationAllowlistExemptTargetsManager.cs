using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public interface ICollaborationAllowlistExemptTargetsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTargets> GetCollaborationWhitelistExemptTargetsAsync(GetCollaborationWhitelistExemptTargetsQueryParams? queryParams = default, GetCollaborationWhitelistExemptTargetsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> CreateCollaborationWhitelistExemptTargetAsync(CreateCollaborationWhitelistExemptTargetRequestBody requestBody, CreateCollaborationWhitelistExemptTargetHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<CollaborationAllowlistExemptTarget> GetCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, GetCollaborationWhitelistExemptTargetByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteCollaborationWhitelistExemptTargetByIdAsync(string collaborationWhitelistExemptTargetId, DeleteCollaborationWhitelistExemptTargetByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}