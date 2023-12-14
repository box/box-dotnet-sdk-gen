using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITermsOfServicesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TermsOfServices> GetTermOfServicesAsync(GetTermOfServicesQueryParams? queryParams = default, GetTermOfServicesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> CreateTermOfServiceAsync(CreateTermOfServiceRequestBody requestBody, CreateTermOfServiceHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> GetTermOfServiceByIdAsync(string termsOfServiceId, GetTermOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> UpdateTermOfServiceByIdAsync(string termsOfServiceId, UpdateTermOfServiceByIdRequestBody requestBody, UpdateTermOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}