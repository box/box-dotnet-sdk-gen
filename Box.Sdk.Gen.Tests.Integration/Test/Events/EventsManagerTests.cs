using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Sdk.Gen.Internal;
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