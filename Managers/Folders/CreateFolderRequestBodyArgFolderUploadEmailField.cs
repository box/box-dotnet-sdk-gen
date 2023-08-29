using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderRequestBodyArgFolderUploadEmailField {
        /// <summary>
        /// When this parameter has been set, users can email files
        /// to the email address that has been automatically
        /// created for this folder.
        /// 
        /// To create an email address, set this property either when
        /// creating or updating the folder.
        /// 
        /// When set to `collaborators`, only emails from registered email
        /// addresses for collaborators will be accepted. This includes
        /// any email aliases a user might have registered.
        /// 
        /// When set to `open` it will accept emails from any email
        /// address.
        /// </summary>
        [JsonPropertyName("access")]
        public CreateFolderRequestBodyArgFolderUploadEmailFieldAccessField? Access { get; set; } = default;

        public CreateFolderRequestBodyArgFolderUploadEmailField() {
            
        }
    }
}