using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileMetadataByIdRequestBodyArg {
        /// <summary>
        /// The type of change to perform on the template. Some
        /// of these are hazardous as they will change existing templates.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateFileMetadataByIdRequestBodyArgOpField? Op { get; set; } = default;

        /// <summary>
        /// The location in the metadata JSON object
        /// to apply the changes to, in the format of a
        /// [JSON-Pointer](https://tools.ietf.org/html/rfc6901).
        /// 
        /// The path must always be prefixed with a `/` to represent the root
        /// of the template. The characters `~` and `/` are reserved
        /// characters and must be escaped in the key.
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; } = default;

        /// <summary>
        /// The value to be set or tested.
        /// 
        /// Required for `add`, `replace`, and `test` operations. For `add`,
        /// if the value exists already the previous value will be overwritten
        /// by the new value. For `replace`, the value must exist before
        /// replacing.
        /// 
        /// For `test`, the existing value at the `path` location must match
        /// the specified value.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; } = default;

        /// <summary>
        /// The location in the metadata JSON object to move or copy a value
        /// from. Required for `move` or `copy` operations and must be in the
        /// format of a [JSON-Pointer](https://tools.ietf.org/html/rfc6901).
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; } = default;

        public UpdateFileMetadataByIdRequestBodyArg() {
            
        }
    }
}