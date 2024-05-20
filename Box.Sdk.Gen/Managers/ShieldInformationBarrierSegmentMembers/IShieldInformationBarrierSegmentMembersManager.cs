using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IShieldInformationBarrierSegmentMembersManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> GetShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, GetShieldInformationBarrierSegmentMemberByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, DeleteShieldInformationBarrierSegmentMemberByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMembers> GetShieldInformationBarrierSegmentMembersAsync(GetShieldInformationBarrierSegmentMembersQueryParams queryParams, GetShieldInformationBarrierSegmentMembersHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> CreateShieldInformationBarrierSegmentMemberAsync(CreateShieldInformationBarrierSegmentMemberRequestBody requestBody, CreateShieldInformationBarrierSegmentMemberHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}