using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IUsersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Users> GetUsersAsync(GetUsersQueryParams? queryParams = default, GetUsersHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> CreateUserAsync(CreateUserRequestBody requestBody, CreateUserQueryParams? queryParams = default, CreateUserHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> GetUserMeAsync(GetUserMeQueryParams? queryParams = default, GetUserMeHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> GetUserByIdAsync(string userId, GetUserByIdQueryParams? queryParams = default, GetUserByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserFull> UpdateUserByIdAsync(string userId, UpdateUserByIdRequestBody? requestBody = default, UpdateUserByIdQueryParams? queryParams = default, UpdateUserByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteUserByIdAsync(string userId, DeleteUserByIdQueryParams? queryParams = default, DeleteUserByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}