using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWorkflowsQueryParamsArg {
        public string FolderId { get; }

        public string TriggerType { get; }

        public int? Limit { get; }

        public string Marker { get; }

        public GetWorkflowsQueryParamsArg(string folderId, string triggerType, int? limit, string marker) {
            FolderId = folderId;
            TriggerType = triggerType;
            Limit = limit;
            Marker = marker;
        }
    }
}