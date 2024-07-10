using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IShieldInformationBarriersManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<ShieldInformationBarrier> GetShieldInformationBarrierByIdAsync(string shieldInformationBarrierId, GetShieldInformationBarrierByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarrier> UpdateShieldInformationBarrierStatusAsync(UpdateShieldInformationBarrierStatusRequestBody requestBody, UpdateShieldInformationBarrierStatusHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarriers> GetShieldInformationBarriersAsync(GetShieldInformationBarriersQueryParams? queryParams = default, GetShieldInformationBarriersHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarrier> CreateShieldInformationBarrierAsync(CreateShieldInformationBarrierRequestBody requestBody, CreateShieldInformationBarrierHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}