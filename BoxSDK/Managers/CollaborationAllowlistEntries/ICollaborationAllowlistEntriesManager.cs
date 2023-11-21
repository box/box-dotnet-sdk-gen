using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ICollaborationAllowlistEntriesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<CollaborationAllowlistEntries> GetCollaborationWhitelistEntriesAsync(GetCollaborationWhitelistEntriesQueryParamsArg? queryParams = default, GetCollaborationWhitelistEntriesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> CreateCollaborationWhitelistEntryAsync(CreateCollaborationWhitelistEntryRequestBodyArg requestBody, CreateCollaborationWhitelistEntryHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CollaborationAllowlistEntry> GetCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, GetCollaborationWhitelistEntryByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationWhitelistEntryByIdAsync(string collaborationWhitelistEntryId, DeleteCollaborationWhitelistEntryByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}