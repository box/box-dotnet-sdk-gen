using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ICollaborationAllowlistEntriesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<CollaborationAllowlistEntries> GetCollaborationWhitelistEntriesAsync(GetCollaborationWhitelistEntriesQueryParams? queryParams = default, GetCollaborationWhitelistEntriesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> CreateCollaborationWhitelistEntryAsync(CreateCollaborationWhitelistEntryRequestBody requestBody, CreateCollaborationWhitelistEntryHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> GetCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, GetCollaborationWhitelistEntryByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, DeleteCollaborationWhitelistEntryByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}