using System.IO;
using Serializer;
using Json;

namespace Box
{
    /// <summary>
    /// Multipart item used in Fetch, usually for stream requests.
    /// </summary>
    public class MultipartItem
    {
        /// <summary>
        /// Name of the multipart item.
        /// </summary>
        public string PartName { get; set; }

        /// <summary>
        /// Name of the multipart item.
        /// </summary>

        public SerializedData? Data { get; set; }

        /// <summary>
        /// A stream containing the contents of a file.
        /// </summary>
        public Stream? FileStream { get; set; }

        /// <summary>
        /// Name of the file.
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Content type of the multipart item.
        /// </summary>
        public string? ContentType { get; set; }

        public MultipartItem(string partName, Stream? fileStream = null, SerializedData? data = null, string? fileName = null, string? contentType = null)
        {
            PartName = partName;
            Data = data;
            FileStream = fileStream;
            FileName = fileName;
            ContentType = contentType;
        }
    }
}
