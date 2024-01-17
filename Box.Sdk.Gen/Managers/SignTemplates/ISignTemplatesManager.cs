using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ISignTemplatesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SignTemplates> GetSignTemplatesAsync(GetSignTemplatesQueryParams? queryParams = default, GetSignTemplatesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SignTemplate> GetSignTemplateByIdAsync(string templateId, GetSignTemplateByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}