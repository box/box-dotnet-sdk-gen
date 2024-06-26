using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IListCollaborationsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Collaborations> GetFileCollaborationsAsync(string fileId, GetFileCollaborationsQueryParams? queryParams = default, GetFileCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<Collaborations> GetFolderCollaborationsAsync(string folderId, GetFolderCollaborationsQueryParams? queryParams = default, GetFolderCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<Collaborations> GetCollaborationsAsync(GetCollaborationsQueryParams queryParams, GetCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<Collaborations> GetGroupCollaborationsAsync(string groupId, GetGroupCollaborationsQueryParams? queryParams = default, GetGroupCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}