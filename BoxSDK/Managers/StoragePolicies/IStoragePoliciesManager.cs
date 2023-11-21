using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IStoragePoliciesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<StoragePolicies> GetStoragePoliciesAsync(GetStoragePoliciesQueryParamsArg? queryParams = default, GetStoragePoliciesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicy> GetStoragePolicyByIdAsync(string storagePolicyId, GetStoragePolicyByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}