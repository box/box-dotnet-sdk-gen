using NullableExtensions;
using System.Linq;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box {
    public class CommonsManager : ICommonsManager {
        public BoxJwtAuth GetJwtAuth() {
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(configJsonString: Utils.DecodeBase64(value: Utils.GetEnvVar(name: "JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            return auth;
        }

        public async System.Threading.Tasks.Task<BoxClient> GetDefaultClientAsUserAsync(string userId) {
            BoxJwtAuth auth = GetJwtAuth();
            await auth.AsUserAsync(userId: userId).ConfigureAwait(false);
            return new BoxClient(auth: auth);
        }

        public BoxClient GetDefaultClient() {
            BoxClient client = new BoxClient(auth: GetJwtAuth());
            return client;
        }

        public async System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync() {
            BoxClient client = new CommonsManager().GetDefaultClient();
            string newFolderName = Utils.GetUUID();
            return await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: newFolderName, parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
        }

        public async System.Threading.Tasks.Task<FileFull> UploadNewFileAsync() {
            BoxClient client = new CommonsManager().GetDefaultClient();
            string newFileName = string.Concat(Utils.GetUUID(), ".pdf");
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: newFileName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            return NullableUtils.Unwrap(uploadedFiles.Entries)[0];
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrier> GetOrCreateShieldInformationBarrierAsync(BoxClient client, string enterpriseId) {
            ShieldInformationBarriers barriers = await client.ShieldInformationBarriers.GetShieldInformationBarriersAsync().ConfigureAwait(false);
            int numberOfBarriers = NullableUtils.Unwrap(barriers.Entries).Count;
            if (numberOfBarriers == 0) {
                return await client.ShieldInformationBarriers.CreateShieldInformationBarrierAsync(requestBody: new CreateShieldInformationBarrierRequestBody(enterprise: new EnterpriseBase() { Id = enterpriseId, Type = EnterpriseBaseTypeField.Enterprise })).ConfigureAwait(false);
            }
            return NullableUtils.Unwrap(barriers.Entries).ElementAt(numberOfBarriers - 1);
        }

    }
}