using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITermsOfServiceUserStatusesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermOfServiceUserStatusesAsync(GetTermOfServiceUserStatusesQueryParams queryParams, GetTermOfServiceUserStatusesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermOfServiceUserStatusAsync(CreateTermOfServiceUserStatusRequestBody requestBody, CreateTermOfServiceUserStatusHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermOfServiceUserStatusByIdAsync(string termsOfServiceUserStatusId, UpdateTermOfServiceUserStatusByIdRequestBody requestBody, UpdateTermOfServiceUserStatusByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}