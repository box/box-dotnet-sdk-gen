using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetTermOfServiceUserStatusesQueryParamsArg {
        public string TosId { get; }

        public string UserId { get; }

        public GetTermOfServiceUserStatusesQueryParamsArg(string tosId, string userId) {
            TosId = tosId;
            UserId = userId;
        }
    }
}