using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IFileMetadataManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Metadatas> GetFileMetadataAsync(string fileId, GetFileMetadataHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> GetFileMetadataByIdAsync(string fileId, GetFileMetadataByIdScope scope, string templateKey, GetFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> CreateFileMetadataByIdAsync(string fileId, CreateFileMetadataByIdScope scope, string templateKey, Dictionary<string, string> requestBody, CreateFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> UpdateFileMetadataByIdAsync(string fileId, UpdateFileMetadataByIdScope scope, string templateKey, IReadOnlyList<UpdateFileMetadataByIdRequestBody> requestBody, UpdateFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileMetadataByIdAsync(string fileId, DeleteFileMetadataByIdScope scope, string templateKey, DeleteFileMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}