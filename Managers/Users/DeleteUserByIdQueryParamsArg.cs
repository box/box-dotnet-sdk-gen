using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteUserByIdQueryParamsArg {
        /// <summary>
        /// Whether the user will receive email notification of
        /// the deletion
        /// </summary>
        public bool? Notify { get; set; } = default;

        /// <summary>
        /// Whether the user should be deleted even if this user
        /// still own files
        /// </summary>
        public bool? Force { get; set; } = default;

        public DeleteUserByIdQueryParamsArg() {
            
        }
    }
}