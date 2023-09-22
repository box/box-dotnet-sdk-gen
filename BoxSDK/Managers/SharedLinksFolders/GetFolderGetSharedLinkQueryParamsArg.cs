using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderGetSharedLinkQueryParamsArg {
        /// <summary>
        /// Explicitly request the `shared_link` fields
        /// to be returned for this item.
        /// </summary>
        public string Fields { get; set; }

        public GetFolderGetSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}