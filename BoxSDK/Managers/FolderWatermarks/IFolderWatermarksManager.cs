using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFolderWatermarksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Watermark> GetFolderWatermarkAsync(string folderId, GetFolderWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Watermark> UpdateFolderWatermarkAsync(string folderId, UpdateFolderWatermarkRequestBody requestBody, UpdateFolderWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderWatermarkAsync(string folderId, DeleteFolderWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}