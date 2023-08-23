using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionRetentionsQueryParamsArg {
        public string FileId { get; }

        public string FileVersionId { get; }

        public string PolicyId { get; }

        public GetFileVersionRetentionsQueryParamsArgDispositionActionField DispositionAction { get; }

        public string DispositionBefore { get; }

        public string DispositionAfter { get; }

        public long? Limit { get; }

        public string Marker { get; }

        public GetFileVersionRetentionsQueryParamsArg(string fileId, string fileVersionId, string policyId, GetFileVersionRetentionsQueryParamsArgDispositionActionField dispositionAction, string dispositionBefore, string dispositionAfter, long? limit, string marker) {
            FileId = fileId;
            FileVersionId = fileVersionId;
            PolicyId = policyId;
            DispositionAction = dispositionAction;
            DispositionBefore = dispositionBefore;
            DispositionAfter = dispositionAfter;
            Limit = limit;
            Marker = marker;
        }
    }
}