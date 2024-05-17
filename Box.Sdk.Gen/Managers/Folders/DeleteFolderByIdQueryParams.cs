using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class DeleteFolderByIdQueryParams {
        /// <summary>
        /// Delete a folder that is not empty by recursively deleting the
        /// folder and all of its content.
        /// </summary>
        public bool? Recursive { get; init; }

        public DeleteFolderByIdQueryParams() {
            
        }
    }
}