using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
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