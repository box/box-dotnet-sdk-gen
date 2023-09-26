using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class EventsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public EventsManager() {
            
        }
        public async System.Threading.Tasks.Task<Events> GetEvents(GetEventsQueryParamsArg? queryParams = default, GetEventsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetEventsQueryParamsArg();
            headers = headers ?? new GetEventsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "stream_type", StringUtils.ToStringRepresentation(queryParams.StreamType) }, { "stream_position", StringUtils.ToStringRepresentation(queryParams.StreamPosition) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "event_type", StringUtils.ToStringRepresentation(queryParams.EventType) }, { "created_after", StringUtils.ToStringRepresentation(queryParams.CreatedAfter) }, { "created_before", StringUtils.ToStringRepresentation(queryParams.CreatedBefore) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/events"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Events>(response.Text);
        }

        public async System.Threading.Tasks.Task<RealtimeServers> GetEventsWithLongPolling(GetEventsWithLongPollingHeadersArg? headers = default) {
            headers = headers ?? new GetEventsWithLongPollingHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/events"), new FetchOptions(method: "OPTIONS", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RealtimeServers>(response.Text);
        }

    }
}