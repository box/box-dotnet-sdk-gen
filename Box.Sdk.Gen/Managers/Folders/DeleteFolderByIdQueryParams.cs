using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

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