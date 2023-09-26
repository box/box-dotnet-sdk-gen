using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteFolderByIdQueryParamsArg {
        /// <summary>
        /// Delete a folder that is not empty by recursively deleting the
        /// folder and all of its content.
        /// </summary>
        public bool? Recursive { get; set; } = default;

        public DeleteFolderByIdQueryParamsArg() {
            
        }
    }
}