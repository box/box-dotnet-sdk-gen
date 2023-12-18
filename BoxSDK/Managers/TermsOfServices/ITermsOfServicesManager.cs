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

        public System.Threading.Tasks.Task<TermsOfServices> GetTermsOfServiceAsync(GetTermsOfServiceQueryParams? queryParams = default, GetTermsOfServiceHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> CreateTermsOfServiceAsync(CreateTermsOfServiceRequestBody requestBody, CreateTermsOfServiceHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> GetTermsOfServiceByIdAsync(string termsOfServiceId, GetTermsOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> UpdateTermsOfServiceByIdAsync(string termsOfServiceId, UpdateTermsOfServiceByIdRequestBody requestBody, UpdateTermsOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}