using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWebLinkGetSharedLinkQueryParamsArg {
        /// <summary>
        /// Explicitly request the `shared_link` fields
        /// to be returned for this item.
        /// </summary>
        public string Fields { get; set; }

        public GetWebLinkGetSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}