using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataCascadePoliciesQueryParamsArg {
        public string FolderId { get; }

        public string OwnerEnterpriseId { get; }

        public string Marker { get; }

        public long? Offset { get; }

        public GetMetadataCascadePoliciesQueryParamsArg(string folderId, string ownerEnterpriseId, string marker, long? offset) {
            FolderId = folderId;
            OwnerEnterpriseId = ownerEnterpriseId;
            Marker = marker;
            Offset = offset;
        }
    }
}