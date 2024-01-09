using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISignRequestsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SignRequest> CancelSignRequestAsync(string signRequestId, CancelSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task ResendSignRequestAsync(string signRequestId, ResendSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SignRequest> GetSignRequestByIdAsync(string signRequestId, GetSignRequestByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SignRequests> GetSignRequestsAsync(GetSignRequestsQueryParams? queryParams = default, GetSignRequestsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SignRequest> CreateSignRequestAsync(SignRequestCreateRequest requestBody, CreateSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}