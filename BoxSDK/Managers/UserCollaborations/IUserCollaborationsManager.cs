using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IUserCollaborationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collaboration> GetCollaborationByIdAsync(string collaborationId, GetCollaborationByIdQueryParams? queryParams = default, GetCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> UpdateCollaborationByIdAsync(string collaborationId, UpdateCollaborationByIdRequestBody requestBody, UpdateCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationByIdAsync(string collaborationId, DeleteCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> CreateCollaborationAsync(CreateCollaborationRequestBody requestBody, CreateCollaborationQueryParams? queryParams = default, CreateCollaborationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}