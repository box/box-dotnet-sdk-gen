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
            User newUser = await client.Users.CreateUser(new CreateUserRequestBodyArg(name: newUserName) { Login = newUserLogin });
            EmailAliases aliases = await client.EmailAliases.GetUserEmailAliases(newUser.Id);
            Assert.IsTrue(aliases.TotalCount == 0);
            string newAliasEmail = string.Concat(newUser.Id, "@boxdemo.com");
            EmailAlias newAlias = await client.EmailAliases.CreateUserEmailAlias(newUser.Id, new CreateUserEmailAliasRequestBodyArg(email: newAliasEmail));
            EmailAliases updatedAliases = await client.EmailAliases.GetUserEmailAliases(newUser.Id);
            Assert.IsTrue(updatedAliases.TotalCount == 1);
            Assert.IsTrue(updatedAliases.Entries[0].Email == newAliasEmail);
            await client.EmailAliases.DeleteUserEmailAliasById(newUser.Id, newAlias.Id);
            EmailAliases finalAliases = await client.EmailAliases.GetUserEmailAliases(newUser.Id);
            Assert.IsTrue(finalAliases.TotalCount == 0);
            await client.Users.DeleteUserById(newUser.Id);
        }

    }
}