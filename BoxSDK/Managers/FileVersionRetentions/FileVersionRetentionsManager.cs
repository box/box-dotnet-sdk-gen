using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileVersionRetentionsManager : IFileVersionRetentionsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileVersionRetentionsManager() {
            
        }
        /// <summary>
        /// Retrieves all file version retentions for the given enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getFileVersionRetentions method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileVersionRetentions method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionRetentions> GetFileVersionRetentionsAsync(GetFileVersionRetentionsQueryParamsArg? queryParams = default, GetFileVersionRetentionsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileVersionRetentionsQueryParamsArg();
            headers = headers ?? new GetFileVersionRetentionsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "file_id", StringUtils.ToStringRepresentation(queryParams.FileId) }, { "file_version_id", StringUtils.ToStringRepresentation(queryParams.FileVersionId) }, { "policy_id", StringUtils.ToStringRepresentation(queryParams.PolicyId) }, { "disposition_action", StringUtils.ToStringRepresentation(queryParams.DispositionAction) }, { "disposition_before", StringUtils.ToStringRepresentation(queryParams.DispositionBefore) }, { "disposition_after", StringUtils.ToStringRepresentation(queryParams.DispositionAfter) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_version_retentions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionRetentions>(response.Data);
        }

        /// <summary>
        /// Returns information about a file version retention.
        /// </summary>
        /// <param name="fileVersionRetentionId">
        /// The ID of the file version retention
        /// Example: "3424234"
        /// </param>
        /// <param name="headers">
        /// Headers of getFileVersionRetentionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionRetention> GetFileVersionRetentionByIdAsync(string fileVersionRetentionId, GetFileVersionRetentionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFileVersionRetentionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_version_retentions/", StringUtils.ToStringRepresentation(fileVersionRetentionId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionRetention>(response.Data);
        }

    }
}