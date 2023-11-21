using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITermsOfServiceUserStatusesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermOfServiceUserStatusesAsync(GetTermOfServiceUserStatusesQueryParamsArg queryParams, GetTermOfServiceUserStatusesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermOfServiceUserStatusAsync(CreateTermOfServiceUserStatusRequestBodyArg requestBody, CreateTermOfServiceUserStatusHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermOfServiceUserStatusByIdAsync(string termsOfServiceUserStatusId, UpdateTermOfServiceUserStatusByIdRequestBodyArg requestBody, UpdateTermOfServiceUserStatusByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}