using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class EventsManagerTests {
        public BoxClient client { get; }

        public EventsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestEvents() {
            Events events = await client.Events.GetEventsAsync();
            Assert.IsTrue(NullableUtils.Unwrap(events.Entries).Count > 0);
            Event firstEvent = NullableUtils.Unwrap(events.Entries)[0];
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(firstEvent.CreatedBy).Type) == "user");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(firstEvent.EventType)) != "");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestEventUpload() {
            Events events = await client.Events.GetEventsAsync(queryParams: new GetEventsQueryParams() { StreamType = GetEventsQueryParamsStreamTypeField.AdminLogs, EventType = Array.AsReadOnly(new [] {new StringEnum<GetEventsQueryParamsEventTypeField>(GetEventsQueryParamsEventTypeField.Upload)}) });
            Assert.IsTrue(NullableUtils.Unwrap(events.Entries).Count > 0);
            Event firstEvent = NullableUtils.Unwrap(events.Entries)[0];
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(firstEvent.EventType)) == "UPLOAD");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestEventDeleteUser() {
            Events events = await client.Events.GetEventsAsync(queryParams: new GetEventsQueryParams() { StreamType = GetEventsQueryParamsStreamTypeField.AdminLogs, EventType = Array.AsReadOnly(new [] {new StringEnum<GetEventsQueryParamsEventTypeField>(GetEventsQueryParamsEventTypeField.DeleteUser)}) });
            Assert.IsTrue(NullableUtils.Unwrap(events.Entries).Count > 0);
            Event firstEvent = NullableUtils.Unwrap(events.Entries)[0];
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(firstEvent.EventType)) == "DELETE_USER");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestEventSourceFileOrFolder() {
            Events events = await client.Events.GetEventsAsync(queryParams: new GetEventsQueryParams() { StreamType = GetEventsQueryParamsStreamTypeField.Changes });
            Assert.IsTrue(NullableUtils.Unwrap(events.Entries).Count > 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetEventsWithLongPolling() {
            RealtimeServers servers = await client.Events.GetEventsWithLongPollingAsync();
            Assert.IsTrue(NullableUtils.Unwrap(servers.Entries).Count > 0);
            RealtimeServer server = NullableUtils.Unwrap(servers.Entries)[0];
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(server.Type)) == "realtime_server");
            Assert.IsTrue(NullableUtils.Unwrap(server.Url) != "");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetEventsWithDateFilters() {
            System.DateTimeOffset createdAfterDate = Utils.DateTimeFromString(dateTime: "2024-06-09T00:00:00Z");
            System.DateTimeOffset createdBeforeDate = Utils.DateTimeFromString(dateTime: "2025-06-09T00:00:00Z");
            Events servers = await client.Events.GetEventsAsync(queryParams: new GetEventsQueryParams() { StreamType = GetEventsQueryParamsStreamTypeField.AdminLogs, Limit = 1, CreatedAfter = createdAfterDate, CreatedBefore = createdBeforeDate });
            Assert.IsTrue(NullableUtils.Unwrap(servers.Entries).Count == 1);
        }

    }
}