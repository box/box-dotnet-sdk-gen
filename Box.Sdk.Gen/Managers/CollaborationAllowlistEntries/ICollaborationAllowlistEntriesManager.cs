using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ICollaborationAllowlistEntriesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<CollaborationAllowlistEntries> GetCollaborationWhitelistEntriesAsync(GetCollaborationWhitelistEntriesQueryParams? queryParams = default, GetCollaborationWhitelistEntriesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> CreateCollaborationWhitelistEntryAsync(CreateCollaborationWhitelistEntryRequestBody requestBody, CreateCollaborationWhitelistEntryHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> GetCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, GetCollaborationWhitelistEntryByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, DeleteCollaborationWhitelistEntryByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}