using System.IO;
using Serializer;
using Serialization.Json;

namespace Box.Sdk.Gen
{
    /// <summary>
    /// Multipart item used in Fetch, usually for stream requests.
    /// </summary>
    class MultipartItem
    {
        /// <summary>
        /// Name of the multipart item.
        /// </summary>
        internal string PartName { get; }

        /// <summary>
        /// Name of the multipart item.
        /// </summary>

        internal SerializedData? Data { get; init; }

        /// <summary>
        /// A stream containing the contents of a file.
        /// </summary>
        internal Stream? FileStream { get; init; }

        /// <summary>
        /// Name of the file.
        /// </summary>
        internal string? FileName { get; init; }

        /// <summary>
        /// Content type of the multipart item.
        /// </summary>
        internal string? ContentType { get; init; }

        public MultipartItem(string partName)
        {
            PartName = partName;
        }
    }
}
