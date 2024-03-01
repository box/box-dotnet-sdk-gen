using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class AvatarsManagerTests {
        public BoxClient client { get; }

        public AvatarsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestAvatars() {
            UserFull user = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            UserAvatar createdAvatar = await client.Avatars.CreateUserAvatarAsync(userId: user.Id, requestBody: new CreateUserAvatarRequestBody(pic: Utils.DecodeBase64ByteStream(data: "iVBORw0KGgoAAAANSUhEUgAAAQAAAAEAAQMAAABmvDolAAAAA1BMVEW10NBjBBbqAAAAH0lEQVRoge3BAQ0AAADCoPdPbQ43oAAAAAAAAAAAvg0hAAABmmDh1QAAAABJRU5ErkJggg==")) { PicContentType = "image/png", PicFileName = "avatar.png" }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(createdAvatar.PicUrls).Small != null);
            Assert.IsTrue(NullableUtils.Unwrap(createdAvatar.PicUrls).Large != null);
            Assert.IsTrue(NullableUtils.Unwrap(createdAvatar.PicUrls).Preview != null);
            System.IO.Stream response = await client.Avatars.GetUserAvatarAsync(userId: user.Id).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(buffer1: await Utils.ReadByteStreamAsync(byteStream: response).ConfigureAwait(false), buffer2: Utils.GenerateByteBuffer(size: 0)) == false);
            await client.Avatars.DeleteUserAvatarAsync(userId: user.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Avatars.GetUserAvatarAsync(userId: user.Id).ConfigureAwait(false));
        }

    }
}