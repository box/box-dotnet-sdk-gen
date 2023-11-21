using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IUsersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Users> GetUsersAsync(GetUsersQueryParamsArg? queryParams = default, GetUsersHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> CreateUserAsync(CreateUserRequestBodyArg requestBody, CreateUserQueryParamsArg? queryParams = default, CreateUserHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> GetUserMeAsync(GetUserMeQueryParamsArg? queryParams = default, GetUserMeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> GetUserByIdAsync(string userId, GetUserByIdQueryParamsArg? queryParams = default, GetUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> UpdateUserByIdAsync(string userId, UpdateUserByIdRequestBodyArg? requestBody = default, UpdateUserByIdQueryParamsArg? queryParams = default, UpdateUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteUserByIdAsync(string userId, DeleteUserByIdQueryParamsArg? queryParams = default, DeleteUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}