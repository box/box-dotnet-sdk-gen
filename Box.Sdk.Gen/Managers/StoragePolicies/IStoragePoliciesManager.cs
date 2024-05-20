using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IStoragePoliciesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<StoragePolicies> GetStoragePoliciesAsync(GetStoragePoliciesQueryParams? queryParams = default, GetStoragePoliciesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<StoragePolicy> GetStoragePolicyByIdAsync(string storagePolicyId, GetStoragePolicyByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}