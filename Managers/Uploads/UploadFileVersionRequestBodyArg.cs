using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileVersionRequestBodyArg {
        /// <summary>
        /// The additional attributes of the file being uploaded. Mainly the
        /// name and the parent folder. These attributes are part of the multi
        /// part request body and are in JSON format.
        /// 
        /// <Message warning>
        /// 
        ///   The `attributes` part of the body must come **before** the
        ///   `file` part. Requests that do not follow this format when
        ///   uploading the file will receive a HTTP `400` error with a
        ///   `metadata_after_file_contents` error code.
        /// 
        /// </Message>
        /// </summary>
        public UploadFileVersionRequestBodyArgAttributesField Attributes { get; set; }

        /// <summary>
        /// The content of the file to upload to Box.
        /// 
        /// <Message warning>
        /// 
        ///   The `attributes` part of the body must come **before** the
        ///   `file` part. Requests that do not follow this format when
        ///   uploading the file will receive a HTTP `400` error with a
        ///   `metadata_after_file_contents` error code.
        /// 
        /// </Message>
        /// </summary>
        public Stream File { get; set; }

        public string? FileFileName { get; set; } = default;

        public string? FileContentType { get; set; } = default;

        public UploadFileVersionRequestBodyArg(UploadFileVersionRequestBodyArgAttributesField attributes, Stream file) {
            Attributes = attributes;
            File = file;
        }
    }
}