using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderFolderUploadEmailField : ISerializable {
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
        [JsonConverter(typeof(StringEnumConverter<FolderFolderUploadEmailAccessField>))]
        public StringEnum<FolderFolderUploadEmailAccessField>? Access { get; init; }

        /// <summary>
        /// The optional upload email address for this folder.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; init; }

        public FolderFolderUploadEmailField() {
            
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}