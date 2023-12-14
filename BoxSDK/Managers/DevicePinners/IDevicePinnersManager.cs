using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IDevicePinnersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<DevicePinner> GetDevicePinnerByIdAsync(string devicePinnerId, GetDevicePinnerByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteDevicePinnerByIdAsync(string devicePinnerId, DeleteDevicePinnerByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<DevicePinners> GetEnterpriseDevicePinnersAsync(string enterpriseId, GetEnterpriseDevicePinnersQueryParams? queryParams = default, GetEnterpriseDevicePinnersHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}