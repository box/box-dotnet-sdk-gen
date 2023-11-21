using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IShieldInformationBarriersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<ShieldInformationBarrier> GetShieldInformationBarrierByIdAsync(string shieldInformationBarrierId, GetShieldInformationBarrierByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrier> CreateShieldInformationBarrierChangeStatusAsync(CreateShieldInformationBarrierChangeStatusRequestBodyArg requestBody, CreateShieldInformationBarrierChangeStatusHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarriers> GetShieldInformationBarriersAsync(GetShieldInformationBarriersQueryParamsArg? queryParams = default, GetShieldInformationBarriersHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrier> CreateShieldInformationBarrierAsync(CreateShieldInformationBarrierRequestBodyArg requestBody, CreateShieldInformationBarrierHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}