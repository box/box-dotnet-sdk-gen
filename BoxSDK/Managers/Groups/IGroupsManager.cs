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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Groups> GetGroupsAsync(GetGroupsQueryParamsArg? queryParams = default, GetGroupsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> CreateGroupAsync(CreateGroupRequestBodyArg requestBody, CreateGroupQueryParamsArg? queryParams = default, CreateGroupHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> GetGroupByIdAsync(string groupId, GetGroupByIdQueryParamsArg? queryParams = default, GetGroupByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupFull> UpdateGroupByIdAsync(string groupId, UpdateGroupByIdRequestBodyArg? requestBody = default, UpdateGroupByIdQueryParamsArg? queryParams = default, UpdateGroupByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteGroupByIdAsync(string groupId, DeleteGroupByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}