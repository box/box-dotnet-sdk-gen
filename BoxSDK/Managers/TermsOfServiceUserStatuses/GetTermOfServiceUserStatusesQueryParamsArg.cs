using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetTermOfServiceUserStatusesQueryParamsArg {
        /// <summary>
        /// The ID of the terms of service.
        /// </summary>
        public string TosId { get; set; }

        /// <summary>
        /// Limits results to the given user ID.
        /// </summary>
        public string? UserId { get; set; } = default;

        public GetTermOfServiceUserStatusesQueryParamsArg(string tosId) {
            TosId = tosId;
        }
    }
}