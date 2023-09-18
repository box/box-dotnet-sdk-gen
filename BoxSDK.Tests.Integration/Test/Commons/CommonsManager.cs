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
        public async System.Threading.Tasks.Task<File> UploadNewFile() {
            string newFileName = string.Concat(Utils.GetUUID(), ".pdf");
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(1024 * 1024);
            Files uploadedFiles = await client.Uploads.UploadFile(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream));
            return uploadedFiles.Entries[0];
        }

        public async System.Threading.Tasks.Task<FolderFull> CreateNewFolder() {
            string newFolderName = Utils.GetUUID();
            return await client.Folders.CreateFolder(new CreateFolderRequestBodyArg(name: newFolderName, parent: new CreateFolderRequestBodyArgParentField(id: "0")));
        }

    }
}