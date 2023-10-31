using Box.Schemas;
using Box.Managers;
using Box;

namespace Box {
    public interface ICommonsManager {
        public BoxClient GetClientWithJwtAuth();

        public BoxClient GetDefaultClient();

        public System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync();

        public System.Threading.Tasks.Task<File> UploadNewFileAsync();

        public BoxClient GetClientWithCcgAuth();
    }
}