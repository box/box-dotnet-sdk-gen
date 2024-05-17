using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IUserCollaborationsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Collaboration> GetCollaborationByIdAsync(string collaborationId, GetCollaborationByIdQueryParams? queryParams = default, GetCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> UpdateCollaborationByIdAsync(string collaborationId, UpdateCollaborationByIdRequestBody requestBody, UpdateCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationByIdAsync(string collaborationId, DeleteCollaborationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> CreateCollaborationAsync(CreateCollaborationRequestBody requestBody, CreateCollaborationQueryParams? queryParams = default, CreateCollaborationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}