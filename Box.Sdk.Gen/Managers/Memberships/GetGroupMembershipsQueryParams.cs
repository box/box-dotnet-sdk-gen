using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetGroupMembershipsQueryParams {
        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; init; }

        /// <summary>
        /// The offset of the item at which to begin the response.
        /// 
        /// Queries with offset parameter value
        /// exceeding 10000 will be rejected
        /// with a 400 response.
        /// </summary>
        public long? Offset { get; init; }

        public GetGroupMembershipsQueryParams() {
            
        }
    }
}