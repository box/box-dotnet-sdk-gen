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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collaboration> GetCollaborationByIdAsync(string collaborationId, GetCollaborationByIdQueryParamsArg? queryParams = default, GetCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> UpdateCollaborationByIdAsync(string collaborationId, UpdateCollaborationByIdRequestBodyArg requestBody, UpdateCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCollaborationByIdAsync(string collaborationId, DeleteCollaborationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Collaboration> CreateCollaborationAsync(CreateCollaborationRequestBodyArg requestBody, CreateCollaborationQueryParamsArg? queryParams = default, CreateCollaborationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}