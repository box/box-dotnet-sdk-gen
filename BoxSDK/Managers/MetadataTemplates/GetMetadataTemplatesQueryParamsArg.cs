using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataTemplatesQueryParamsArg {
        /// <summary>
        /// The ID of an instance of the metadata template to find.
        /// </summary>
        public string MetadataInstanceId { get; set; }

        public GetMetadataTemplatesQueryParamsArg(string metadataInstanceId) {
            MetadataInstanceId = metadataInstanceId;
        }
    }
}