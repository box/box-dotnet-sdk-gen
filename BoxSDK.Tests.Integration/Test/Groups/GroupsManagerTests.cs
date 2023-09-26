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
            Groups groups = await client.Groups.GetGroups();
            Assert.IsTrue(groups.TotalCount >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetDeleteGroup() {
            string groupName = Utils.GetUUID();
            const string groupDescription = "Group description";
            Group group = await client.Groups.CreateGroup(new CreateGroupRequestBodyArg(name: groupName) { Description = groupDescription });
            Assert.IsTrue(group.Name == groupName);
            GroupFull groupById = await client.Groups.GetGroupById(group.Id, new GetGroupByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"id","name","description","group_type"}) });
            Assert.IsTrue(groupById.Id == group.Id);
            Assert.IsTrue(groupById.Description == groupDescription);
            string updatedGroupName = Utils.GetUUID();
            GroupFull updatedGroup = await client.Groups.UpdateGroupById(group.Id, new UpdateGroupByIdRequestBodyArg() { Name = updatedGroupName });
            Assert.IsTrue(updatedGroup.Name == updatedGroupName);
            await client.Groups.DeleteGroupById(group.Id);
            await Assert.ThrowsExceptionAsync<Exception>(async() => await client.Groups.GetGroupById(group.Id));
        }

    }
}