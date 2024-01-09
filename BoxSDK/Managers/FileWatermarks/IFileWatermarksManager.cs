using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileWatermarksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Watermark> GetFileWatermarkAsync(string fileId, GetFileWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Watermark> UpdateFileWatermarkAsync(string fileId, UpdateFileWatermarkRequestBody requestBody, UpdateFileWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileWatermarkAsync(string fileId, DeleteFileWatermarkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}