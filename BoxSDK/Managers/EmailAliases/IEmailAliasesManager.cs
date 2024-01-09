using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IEmailAliasesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<EmailAliases> GetUserEmailAliasesAsync(string userId, GetUserEmailAliasesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<EmailAlias> CreateUserEmailAliasAsync(string userId, CreateUserEmailAliasRequestBody requestBody, CreateUserEmailAliasHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteUserEmailAliasByIdAsync(string userId, string emailAliasId, DeleteUserEmailAliasByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}