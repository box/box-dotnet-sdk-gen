using Box.Schemas;
using Box;
using Box.Managers;

namespace Box {
    public class CommonsManager : ICommonsManager {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public CommonsManager() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        public async System.Threading.Tasks.Task<File> UploadNewFileAsync() {
            string newFileName = string.Concat(Utils.GetUUID(), ".pdf");
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(1024 * 1024);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            return uploadedFiles.Entries[0];
        }

        public async System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync() {
            string newFolderName = Utils.GetUUID();
            return await client.Folders.CreateFolderAsync(new CreateFolderRequestBodyArg(name: newFolderName, parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
        }

    }
}