using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFolderMetadataManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Metadatas> GetFolderMetadataAsync(string folderId, GetFolderMetadataHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> GetFolderMetadataByIdAsync(string folderId, GetFolderMetadataByIdScope scope, string templateKey, GetFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> CreateFolderMetadataByIdAsync(string folderId, CreateFolderMetadataByIdScope scope, string templateKey, CreateFolderMetadataByIdRequestBody requestBody, CreateFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> UpdateFolderMetadataByIdAsync(string folderId, UpdateFolderMetadataByIdScope scope, string templateKey, IReadOnlyList<UpdateFolderMetadataByIdRequestBody> requestBody, UpdateFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderMetadataByIdAsync(string folderId, DeleteFolderMetadataByIdScope scope, string templateKey, DeleteFolderMetadataByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}