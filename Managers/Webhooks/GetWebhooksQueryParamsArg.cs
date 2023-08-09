using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWebhooksQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public GetWebhooksQueryParamsArg(string marker, int? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}