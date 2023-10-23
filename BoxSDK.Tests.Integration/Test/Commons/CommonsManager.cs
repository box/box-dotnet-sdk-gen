using Box.Schemas;
using Box.Managers;
using Box;

namespace Box {
    public class CommonsManager : ICommonsManager {
        public BoxClient GetClientWithJwtAuth() {
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            BoxClient client = new BoxClient(auth: auth);
            return client;
        }

        public BoxClient GetDefaultClient() {
            return GetClientWithJwtAuth();
        }

        public async System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync() {
            BoxClient client = new CommonsManager().GetDefaultClient();
            string newFolderName = Utils.GetUUID();
            return await client.Folders.CreateFolderAsync(new CreateFolderRequestBodyArg(name: newFolderName, parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
        }

        public async System.Threading.Tasks.Task<File> UploadNewFileAsync() {
            BoxClient client = new CommonsManager().GetDefaultClient();
            string newFileName = string.Concat(Utils.GetUUID(), ".pdf");
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(1024 * 1024);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            return uploadedFiles.Entries![0];
        }

        public BoxClient GetClientWithCcgAuth() {
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar("CLIENT_ID"), clientSecret: Utils.GetEnvVar("CLIENT_SECRET"), enterpriseId: Utils.GetEnvVar("ENTERPRISE_ID"));
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            BoxClient client = new BoxClient(auth: auth);
            return client;
        }

    }
}