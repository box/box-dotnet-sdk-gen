using Box.Schemas;
using Box.Managers;
using Box;

namespace Box {
public interface ICommonsManager {
    public BoxJwtAuth GetJwtAuth();

    public System.Threading.Tasks.Task<BoxClient> GetDefaultClientAsUserAsync(string userId);

    public BoxClient GetDefaultClient();

    public System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync();

    public System.Threading.Tasks.Task<FileFull> UploadNewFileAsync();

}
}