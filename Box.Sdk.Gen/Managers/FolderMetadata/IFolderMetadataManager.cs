using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IFolderMetadataManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Metadatas> GetFolderMetadataAsync(string folderId, GetFolderMetadataHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> GetFolderMetadataByIdAsync(string folderId, GetFolderMetadataByIdScope scope, string templateKey, GetFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> CreateFolderMetadataByIdAsync(string folderId, CreateFolderMetadataByIdScope scope, string templateKey, Dictionary<string, string> requestBody, CreateFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> UpdateFolderMetadataByIdAsync(string folderId, UpdateFolderMetadataByIdScope scope, string templateKey, IReadOnlyList<UpdateFolderMetadataByIdRequestBody> requestBody, UpdateFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderMetadataByIdAsync(string folderId, DeleteFolderMetadataByIdScope scope, string templateKey, DeleteFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}