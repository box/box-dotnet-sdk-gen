using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IGroupsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Groups> GetGroupsAsync(GetGroupsQueryParams? queryParams = default, GetGroupsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> CreateGroupAsync(CreateGroupRequestBody requestBody, CreateGroupQueryParams? queryParams = default, CreateGroupHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> GetGroupByIdAsync(string groupId, GetGroupByIdQueryParams? queryParams = default, GetGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> UpdateGroupByIdAsync(string groupId, UpdateGroupByIdRequestBody? requestBody = default, UpdateGroupByIdQueryParams? queryParams = default, UpdateGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteGroupByIdAsync(string groupId, DeleteGroupByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}