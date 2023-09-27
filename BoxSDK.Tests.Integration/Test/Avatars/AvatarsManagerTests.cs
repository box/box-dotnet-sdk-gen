using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class AvatarsManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public AvatarsManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestAvatars() {
            UserFull user = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            UserAvatar createdAvatar = await client.Avatars.CreateUserAvatarAsync(user.Id, new CreateUserAvatarRequestBodyArg(pic: Utils.DecodeBase64ByteStream("iVBORw0KGgoAAAANSUhEUgAAAQAAAAEAAQMAAABmvDolAAAAA1BMVEW10NBjBBbqAAAAH0lEQVRoge3BAQ0AAADCoPdPbQ43oAAAAAAAAAAAvg0hAAABmmDh1QAAAABJRU5ErkJggg==")) { PicContentType = "image/png", PicFileName = "avatar.png" }).ConfigureAwait(false);
            Assert.IsTrue(createdAvatar.PicUrls.Small != null);
            Assert.IsTrue(createdAvatar.PicUrls.Large != null);
            Assert.IsTrue(createdAvatar.PicUrls.Preview != null);
            System.IO.Stream response = await client.Avatars.GetUserAvatarAsync(user.Id).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStreamAsync(response).ConfigureAwait(false), Utils.GenerateByteBuffer(0)) == false);
            await client.Avatars.DeleteUserAvatarAsync(user.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Avatars.GetUserAvatarAsync(user.Id).ConfigureAwait(false));
        }

    }
}