using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IGroupsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Groups> GetGroupsAsync(GetGroupsQueryParams? queryParams = default, GetGroupsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> CreateGroupAsync(CreateGroupRequestBody requestBody, CreateGroupQueryParams? queryParams = default, CreateGroupHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> GetGroupByIdAsync(string groupId, GetGroupByIdQueryParams? queryParams = default, GetGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> UpdateGroupByIdAsync(string groupId, UpdateGroupByIdRequestBody? requestBody = default, UpdateGroupByIdQueryParams? queryParams = default, UpdateGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteGroupByIdAsync(string groupId, DeleteGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}