using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWebhooksQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetWebhooksQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}