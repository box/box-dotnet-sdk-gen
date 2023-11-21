using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IMembershipsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<GroupMemberships> GetUserMembershipsAsync(string userId, GetUserMembershipsQueryParamsArg? queryParams = default, GetUserMembershipsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMemberships> GetGroupMembershipsAsync(string groupId, GetGroupMembershipsQueryParamsArg? queryParams = default, GetGroupMembershipsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> CreateGroupMembershipAsync(CreateGroupMembershipRequestBodyArg requestBody, CreateGroupMembershipQueryParamsArg? queryParams = default, CreateGroupMembershipHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> GetGroupMembershipByIdAsync(string groupMembershipId, GetGroupMembershipByIdQueryParamsArg? queryParams = default, GetGroupMembershipByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> UpdateGroupMembershipByIdAsync(string groupMembershipId, UpdateGroupMembershipByIdRequestBodyArg? requestBody = default, UpdateGroupMembershipByIdQueryParamsArg? queryParams = default, UpdateGroupMembershipByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteGroupMembershipByIdAsync(string groupMembershipId, DeleteGroupMembershipByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}