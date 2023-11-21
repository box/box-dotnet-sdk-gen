using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IListCollaborationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collaborations> GetFileCollaborationsAsync(string fileId, GetFileCollaborationsQueryParamsArg? queryParams = default, GetFileCollaborationsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetFolderCollaborationsAsync(string folderId, GetFolderCollaborationsQueryParamsArg? queryParams = default, GetFolderCollaborationsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetCollaborationsAsync(GetCollaborationsQueryParamsArg queryParams, GetCollaborationsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaborations> GetGroupCollaborationsAsync(string groupId, GetGroupCollaborationsQueryParamsArg? queryParams = default, GetGroupCollaborationsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}