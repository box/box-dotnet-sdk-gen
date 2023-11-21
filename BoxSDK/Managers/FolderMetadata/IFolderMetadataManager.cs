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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Metadatas> GetFolderMetadataAsync(string folderId, GetFolderMetadataHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> GetFolderMetadataByIdAsync(string folderId, GetFolderMetadataByIdScopeArg scope, string templateKey, GetFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> CreateFolderMetadataByIdAsync(string folderId, CreateFolderMetadataByIdScopeArg scope, string templateKey, CreateFolderMetadataByIdRequestBodyArg requestBody, CreateFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataFull> UpdateFolderMetadataByIdAsync(string folderId, UpdateFolderMetadataByIdScopeArg scope, string templateKey, IReadOnlyList<UpdateFolderMetadataByIdRequestBodyArg> requestBody, UpdateFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderMetadataByIdAsync(string folderId, DeleteFolderMetadataByIdScopeArg scope, string templateKey, DeleteFolderMetadataByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}