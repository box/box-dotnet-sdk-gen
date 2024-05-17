using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IAiManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<AiResponse> CreateAiAskAsync(AiAsk requestBody, CreateAiAskHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<AiResponse> CreateAiTextGenAsync(AiTextGen requestBody, CreateAiTextGenHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}