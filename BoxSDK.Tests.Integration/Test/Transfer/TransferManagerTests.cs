using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class TransferManagerTests {
        public BoxClient client { get; }

        public TransferManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTransferUserContent() {
            string newUserName = Utils.GetUUID();
            UserFull newUser = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBodyArg(name: newUserName) { IsPlatformAccessOnly = true }).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            FolderFull transferedFolder = await client.Transfer.TransferOwnedFolderAsync(userId: newUser.Id, requestBody: new TransferOwnedFolderRequestBodyArg(ownedBy: new TransferOwnedFolderRequestBodyArgOwnedByField(id: currentUser.Id)), queryParams: new TransferOwnedFolderQueryParamsArg() { Notify = false }).ConfigureAwait(false);
            Assert.IsTrue(transferedFolder.OwnedBy!.Id == currentUser.Id);
            await client.Folders.DeleteFolderByIdAsync(folderId: transferedFolder.Id, queryParams: new DeleteFolderByIdQueryParamsArg() { Recursive = true }).ConfigureAwait(false);
            await client.Users.DeleteUserByIdAsync(userId: newUser.Id, queryParams: new DeleteUserByIdQueryParamsArg() { Notify = false, Force = true }).ConfigureAwait(false);
        }

    }
}