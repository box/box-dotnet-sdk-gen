using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IMembershipsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<GroupMemberships> GetUserMembershipsAsync(string userId, GetUserMembershipsQueryParams? queryParams = default, GetUserMembershipsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMemberships> GetGroupMembershipsAsync(string groupId, GetGroupMembershipsQueryParams? queryParams = default, GetGroupMembershipsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> CreateGroupMembershipAsync(CreateGroupMembershipRequestBody requestBody, CreateGroupMembershipQueryParams? queryParams = default, CreateGroupMembershipHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> GetGroupMembershipByIdAsync(string groupMembershipId, GetGroupMembershipByIdQueryParams? queryParams = default, GetGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<GroupMembership> UpdateGroupMembershipByIdAsync(string groupMembershipId, UpdateGroupMembershipByIdRequestBody? requestBody = default, UpdateGroupMembershipByIdQueryParams? queryParams = default, UpdateGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteGroupMembershipByIdAsync(string groupMembershipId, DeleteGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}