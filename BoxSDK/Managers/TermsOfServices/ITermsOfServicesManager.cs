using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITermsOfServicesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TermsOfServices> GetTermOfServicesAsync(GetTermOfServicesQueryParamsArg? queryParams = default, GetTermOfServicesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Task> CreateTermOfServiceAsync(CreateTermOfServiceRequestBodyArg requestBody, CreateTermOfServiceHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> GetTermOfServiceByIdAsync(string termsOfServiceId, GetTermOfServiceByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfService> UpdateTermOfServiceByIdAsync(string termsOfServiceId, UpdateTermOfServiceByIdRequestBodyArg requestBody, UpdateTermOfServiceByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}