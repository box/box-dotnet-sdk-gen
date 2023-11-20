using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class GroupsManagerTests {
        public BoxClient client { get; }

        public GroupsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetGroups() {
            Groups groups = await client.Groups.GetGroupsAsync().ConfigureAwait(false);
            Assert.IsTrue(groups.TotalCount! >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetDeleteGroup() {
            string groupName = Utils.GetUUID();
            const string groupDescription = "Group description";
            GroupFull group = await client.Groups.CreateGroupAsync(requestBody: new CreateGroupRequestBodyArg(name: groupName) { Description = groupDescription }).ConfigureAwait(false);
            Assert.IsTrue(group.Name == groupName);
            GroupFull groupById = await client.Groups.GetGroupByIdAsync(groupId: group.Id, queryParams: new GetGroupByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"id","name","description","group_type"}) }).ConfigureAwait(false);
            Assert.IsTrue(groupById.Id == group.Id);
            Assert.IsTrue(groupById.Description == groupDescription);
            string updatedGroupName = Utils.GetUUID();
            GroupFull updatedGroup = await client.Groups.UpdateGroupByIdAsync(groupId: group.Id, requestBody: new UpdateGroupByIdRequestBodyArg() { Name = updatedGroupName }).ConfigureAwait(false);
            Assert.IsTrue(updatedGroup.Name == updatedGroupName);
            await client.Groups.DeleteGroupByIdAsync(groupId: group.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Groups.GetGroupByIdAsync(groupId: group.Id).ConfigureAwait(false));
        }

    }
}