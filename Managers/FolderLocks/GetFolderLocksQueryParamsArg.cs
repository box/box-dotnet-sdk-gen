using System.IO;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderLocksQueryParamsArg {
        public string FolderId { get; }

        public GetFolderLocksQueryParamsArg(string folderId) {
            FolderId = folderId;
        }
    }
}