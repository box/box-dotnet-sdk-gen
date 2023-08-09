using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataCascadePoliciesQueryParamsArg {
        public string FolderId { get; }

        public string OwnerEnterpriseId { get; }

        public string Marker { get; }

        public int? Offset { get; }

        public GetMetadataCascadePoliciesQueryParamsArg(string folderId, string ownerEnterpriseId, string marker, int? offset) {
            FolderId = folderId;
            OwnerEnterpriseId = ownerEnterpriseId;
            Marker = marker;
            Offset = offset;
        }
    }
}