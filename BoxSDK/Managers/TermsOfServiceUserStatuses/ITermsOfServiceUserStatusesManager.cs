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

        public System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermsOfServiceUserStatusesAsync(GetTermsOfServiceUserStatusesQueryParams queryParams, GetTermsOfServiceUserStatusesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermsOfServiceStatusForUserAsync(CreateTermsOfServiceStatusForUserRequestBody requestBody, CreateTermsOfServiceStatusForUserHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermsOfServiceStatusForUserByIdAsync(string termsOfServiceUserStatusId, UpdateTermsOfServiceStatusForUserByIdRequestBody requestBody, UpdateTermsOfServiceStatusForUserByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}