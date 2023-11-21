using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IInvitesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Invite> CreateInviteAsync(CreateInviteRequestBodyArg requestBody, CreateInviteQueryParamsArg? queryParams = default, CreateInviteHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Invite> GetInviteByIdAsync(string inviteId, GetInviteByIdQueryParamsArg? queryParams = default, GetInviteByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}