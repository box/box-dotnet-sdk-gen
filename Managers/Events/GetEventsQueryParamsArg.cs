using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetEventsQueryParamsArg {
        public GetEventsQueryParamsArgStreamTypeField StreamType { get; }

        public string StreamPosition { get; }

        public int? Limit { get; }

        public string EventType { get; }

        public string CreatedAfter { get; }

        public string CreatedBefore { get; }

        public GetEventsQueryParamsArg(GetEventsQueryParamsArgStreamTypeField streamType, string streamPosition, int? limit, string eventType, string createdAfter, string createdBefore) {
            StreamType = streamType;
            StreamPosition = streamPosition;
            Limit = limit;
            EventType = eventType;
            CreatedAfter = createdAfter;
            CreatedBefore = createdBefore;
        }
    }
}