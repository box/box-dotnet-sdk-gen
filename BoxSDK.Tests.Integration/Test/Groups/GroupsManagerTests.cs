using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class GroupsManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public GroupsManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetGroups() {
            Groups groups = await client.Groups.GetGroupsAsync().ConfigureAwait(false);
            Assert.IsTrue(groups.TotalCount >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetDeleteGroup() {
            string groupName = Utils.GetUUID();
            const string groupDescription = "Group description";
            Group group = await client.Groups.CreateGroupAsync(new CreateGroupRequestBodyArg(name: groupName) { Description = groupDescription }).ConfigureAwait(false);
            Assert.IsTrue(group.Name == groupName);
            GroupFull groupById = await client.Groups.GetGroupByIdAsync(group.Id, new GetGroupByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"id","name","description","group_type"}) }).ConfigureAwait(false);
            Assert.IsTrue(groupById.Id == group.Id);
            Assert.IsTrue(groupById.Description == groupDescription);
            string updatedGroupName = Utils.GetUUID();
            GroupFull updatedGroup = await client.Groups.UpdateGroupByIdAsync(group.Id, new UpdateGroupByIdRequestBodyArg() { Name = updatedGroupName }).ConfigureAwait(false);
            Assert.IsTrue(updatedGroup.Name == updatedGroupName);
            await client.Groups.DeleteGroupByIdAsync(group.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Groups.GetGroupByIdAsync(group.Id).ConfigureAwait(false));
        }

    }
}