using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IListCollaborationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collaborations> GetFileCollaborationsAsync(string fileId, GetFileCollaborationsQueryParams? queryParams = default, GetFileCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetFolderCollaborationsAsync(string folderId, GetFolderCollaborationsQueryParams? queryParams = default, GetFolderCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetCollaborationsAsync(GetCollaborationsQueryParams queryParams, GetCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetGroupCollaborationsAsync(string groupId, GetGroupCollaborationsQueryParams? queryParams = default, GetGroupCollaborationsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}