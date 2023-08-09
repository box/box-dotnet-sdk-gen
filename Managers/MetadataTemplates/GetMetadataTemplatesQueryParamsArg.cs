using System.IO;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataTemplatesQueryParamsArg {
        public string MetadataInstanceId { get; }

        public GetMetadataTemplatesQueryParamsArg(string metadataInstanceId) {
            MetadataInstanceId = metadataInstanceId;
        }
    }
}