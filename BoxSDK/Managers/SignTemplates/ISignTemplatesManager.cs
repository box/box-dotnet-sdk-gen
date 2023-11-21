using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISignTemplatesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SignTemplates> GetSignTemplatesAsync(GetSignTemplatesQueryParamsArg? queryParams = default, GetSignTemplatesHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SignTemplate> GetSignTemplateByIdAsync(string templateId, GetSignTemplateByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}