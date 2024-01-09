using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileVersionRetentionsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileVersionRetentions> GetFileVersionRetentionsAsync(GetFileVersionRetentionsQueryParams? queryParams = default, GetFileVersionRetentionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionRetention> GetFileVersionRetentionByIdAsync(string fileVersionRetentionId, GetFileVersionRetentionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}