using Box.Schemas;
using Box;
using Box.Managers;

namespace Box {
    public interface ICommonsManager {
        public System.Threading.Tasks.Task<File> UploadNewFileAsync();

        public System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync();
    }
}