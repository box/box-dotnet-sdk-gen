using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class GetAiAgentDefaultQueryParams {
        /// <summary>
        /// The mode to filter the agent config to return.
        /// </summary>
        public StringEnum<GetAiAgentDefaultQueryParamsModeField> Mode { get; }

        /// <summary>
        /// The ISO language code to return the agent config for.
        /// If the language is not supported the default agent config is returned.
        /// </summary>
        public string? Language { get; init; }

        /// <summary>
        /// The model to return the default agent config for.
        /// </summary>
        public string? Model { get; init; }

        public GetAiAgentDefaultQueryParams(GetAiAgentDefaultQueryParamsModeField mode) {
            Mode = mode;
        }
    }
}