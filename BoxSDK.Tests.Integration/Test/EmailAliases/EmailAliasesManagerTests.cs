using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class EmailAliasesManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public EmailAliasesManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestEmailAliases() {
            string newUserName = Utils.GetUUID();
            string newUserLogin = string.Concat(Utils.GetUUID(), "@boxdemo.com");
            User newUser = await client.Users.CreateUserAsync(new CreateUserRequestBodyArg(name: newUserName) { Login = newUserLogin }).ConfigureAwait(false);
            EmailAliases aliases = await client.EmailAliases.GetUserEmailAliasesAsync(newUser.Id).ConfigureAwait(false);
            Assert.IsTrue(aliases.TotalCount == 0);
            string newAliasEmail = string.Concat(newUser.Id, "@boxdemo.com");
            EmailAlias newAlias = await client.EmailAliases.CreateUserEmailAliasAsync(newUser.Id, new CreateUserEmailAliasRequestBodyArg(email: newAliasEmail)).ConfigureAwait(false);
            EmailAliases updatedAliases = await client.EmailAliases.GetUserEmailAliasesAsync(newUser.Id).ConfigureAwait(false);
            Assert.IsTrue(updatedAliases.TotalCount == 1);
            Assert.IsTrue(updatedAliases.Entries[0].Email == newAliasEmail);
            await client.EmailAliases.DeleteUserEmailAliasByIdAsync(newUser.Id, newAlias.Id).ConfigureAwait(false);
            EmailAliases finalAliases = await client.EmailAliases.GetUserEmailAliasesAsync(newUser.Id).ConfigureAwait(false);
            Assert.IsTrue(finalAliases.TotalCount == 0);
            await client.Users.DeleteUserByIdAsync(newUser.Id).ConfigureAwait(false);
        }

    }
}