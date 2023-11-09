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
        /// <summary>
        /// Returns up to a year of past events for a given user
        /// or for the entire enterprise.
        /// 
        /// By default this returns events for the authenticated user. To retrieve events
        /// for the entire enterprise, set the `stream_type` to `admin_logs_streaming`
        /// for live monitoring of new events, or `admin_logs` for querying across
        /// historical events. The user making the API call will
        /// need to have admin privileges, and the application will need to have the
        /// scope `manage enterprise properties` checked.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getEvents method
        /// </param>
        /// <param name="headers">
        /// Headers of getEvents method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Events> GetEventsAsync(GetEventsQueryParamsArg? queryParams = default, GetEventsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetEventsQueryParamsArg();
            headers = headers ?? new GetEventsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "stream_type", StringUtils.ToStringRepresentation(queryParams.StreamType) }, { "stream_position", StringUtils.ToStringRepresentation(queryParams.StreamPosition) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "event_type", StringUtils.ToStringRepresentation(queryParams.EventType) }, { "created_after", StringUtils.ToStringRepresentation(queryParams.CreatedAfter) }, { "created_before", StringUtils.ToStringRepresentation(queryParams.CreatedBefore) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/events"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Events>(response.Data);
        }

        /// <summary>
        /// Returns a list of real-time servers that can be used for long-polling updates
        /// to the [event stream](#get-events).
        /// 
        /// Long polling is the concept where a HTTP request is kept open until the
        /// server sends a response, then repeating the process over and over to receive
        /// updated responses.
        /// 
        /// Long polling the event stream can only be used for user events, not for
        /// enterprise events.
        /// 
        /// To use long polling, first use this endpoint to retrieve a list of long poll
        /// URLs. Next, make a long poll request to any of the provided URLs.
        /// 
        /// When an event occurs in monitored account a response with the value
        /// `new_change` will be sent. The response contains no other details as
        /// it only serves as a prompt to take further action such as sending a
        /// request to the [events endpoint](#get-events) with the last known
        /// `stream_position`.
        /// 
        /// After the server sends this response it closes the connection. You must now
        /// repeat the long poll process to begin listening for events again.
        /// 
        /// If no events occur for a while and the connection times out you will
        /// receive a response with the value `reconnect`. When you receive this response
        /// you’ll make another call to this endpoint to restart the process.
        /// 
        /// If you receive no events in `retry_timeout` seconds then you will need to
        /// make another request to the real-time server (one of the URLs in the response
        /// for this endpoint). This might be necessary due to network errors.
        /// 
        /// Finally, if you receive a `max_retries` error when making a request to the
        /// real-time server, you should start over by making a call to this endpoint
        /// first.
        /// </summary>
        /// <param name="headers">
        /// Headers of getEventsWithLongPolling method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RealtimeServers> GetEventsWithLongPollingAsync(GetEventsWithLongPollingHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetEventsWithLongPollingHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/events"), new FetchOptions(method: "OPTIONS", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<RealtimeServers>(response.Data);
        }

    }
}