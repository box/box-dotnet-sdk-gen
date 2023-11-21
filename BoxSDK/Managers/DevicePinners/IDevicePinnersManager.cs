using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IDevicePinnersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<DevicePinner> GetDevicePinnerByIdAsync(string devicePinnerId, GetDevicePinnerByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteDevicePinnerByIdAsync(string devicePinnerId, DeleteDevicePinnerByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<DevicePinners> GetEnterpriseDevicePinnersAsync(string enterpriseId, GetEnterpriseDevicePinnersQueryParamsArg? queryParams = default, GetEnterpriseDevicePinnersHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}