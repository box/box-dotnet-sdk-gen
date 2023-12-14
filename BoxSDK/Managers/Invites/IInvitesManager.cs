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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Invite> CreateInviteAsync(CreateInviteRequestBody requestBody, CreateInviteQueryParams? queryParams = default, CreateInviteHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Invite> GetInviteByIdAsync(string inviteId, GetInviteByIdQueryParams? queryParams = default, GetInviteByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}