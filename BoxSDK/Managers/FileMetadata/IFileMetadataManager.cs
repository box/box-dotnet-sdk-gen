using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileMetadataManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Metadatas> GetFileMetadataAsync(string fileId, GetFileMetadataHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> GetFileMetadataByIdAsync(string fileId, GetFileMetadataByIdScope scope, string templateKey, GetFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> CreateFileMetadataByIdAsync(string fileId, CreateFileMetadataByIdScope scope, string templateKey, Dictionary<string, string> requestBody, CreateFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> UpdateFileMetadataByIdAsync(string fileId, UpdateFileMetadataByIdScope scope, string templateKey, IReadOnlyList<UpdateFileMetadataByIdRequestBody> requestBody, UpdateFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileMetadataByIdAsync(string fileId, DeleteFileMetadataByIdScope scope, string templateKey, DeleteFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}