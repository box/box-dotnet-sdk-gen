using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionRetentionsQueryParamsArg {
        /// <summary>
        /// Filters results by files with this ID.
        /// </summary>
        public string? FileId { get; set; } = default;

        /// <summary>
        /// Filters results by file versions with this ID.
        /// </summary>
        public string? FileVersionId { get; set; } = default;

        /// <summary>
        /// Filters results by the retention policy with this ID.
        /// </summary>
        public string? PolicyId { get; set; } = default;

        /// <summary>
        /// Filters results by the retention policy with this disposition
        /// action.
        /// </summary>
        public GetFileVersionRetentionsQueryParamsArgDispositionActionField? DispositionAction { get; set; } = default;

        /// <summary>
        /// Filters results by files that will have their disposition
        /// come into effect before this date.
        /// </summary>
        public string? DispositionBefore { get; set; } = default;

        /// <summary>
        /// Filters results by files that will have their disposition
        /// come into effect after this date.
        /// </summary>
        public string? DispositionAfter { get; set; } = default;

        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; set; } = default;

        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// 
        /// This requires `usemarker` to be set to `true`.
        /// </summary>
        public string? Marker { get; set; } = default;

        public GetFileVersionRetentionsQueryParamsArg() {
            
        }
    }
}