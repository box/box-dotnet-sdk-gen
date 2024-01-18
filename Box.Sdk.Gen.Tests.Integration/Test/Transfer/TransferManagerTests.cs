using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class TransferManagerTests {
        public BoxClient client { get; }

        public TransferManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTransferUserContent() {
            string newUserName = Utils.GetUUID();
            UserFull newUser = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBody(name: newUserName) { IsPlatformAccessOnly = true }).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            FolderFull transferedFolder = await client.Transfer.TransferOwnedFolderAsync(userId: newUser.Id, requestBody: new TransferOwnedFolderRequestBody(ownedBy: new TransferOwnedFolderRequestBodyOwnedByField(id: currentUser.Id)), queryParams: new TransferOwnedFolderQueryParams() { Notify = false }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(transferedFolder.OwnedBy).Id == currentUser.Id);
            await client.Folders.DeleteFolderByIdAsync(folderId: transferedFolder.Id, queryParams: new DeleteFolderByIdQueryParams() { Recursive = true }).ConfigureAwait(false);
            await client.Users.DeleteUserByIdAsync(userId: newUser.Id, queryParams: new DeleteUserByIdQueryParams() { Notify = false, Force = true }).ConfigureAwait(false);
        }

    }
}