using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class DeleteUserByIdQueryParams {
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

        public DeleteUserByIdQueryParams() {
            
        }
    }
}