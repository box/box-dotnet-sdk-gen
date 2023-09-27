using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class UploadsManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public UploadsManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestUploadFileAndFileVersion() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(1048576);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            File uploadedFile = uploadedFiles.Entries[0];
            Assert.IsTrue(uploadedFile.Name == newFileName);
            string newFileVersionName = Utils.GetUUID();
            System.IO.Stream newFileContentStream = Utils.GenerateByteStream(1048576);
            Files uploadedFilesVersion = await client.Uploads.UploadFileVersionAsync(uploadedFile.Id, new UploadFileVersionRequestBodyArg(attributes: new UploadFileVersionRequestBodyArgAttributesField(name: newFileVersionName), file: newFileContentStream)).ConfigureAwait(false);
            File newFileVersion = uploadedFilesVersion.Entries[0];
            Assert.IsTrue(newFileVersion.Name == newFileVersionName);
            await client.Files.DeleteFileByIdAsync(newFileVersion.Id).ConfigureAwait(false);
        }

    }
}