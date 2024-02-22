using System.IO;
using Serializer;
using Serialization.Json;

namespace Fetch
{
    /// <summary>
    /// Result of a Fetch call.
    /// </summary>
    public class FetchResponse
    {
        /// <summary>
        /// Status code of a response.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Response text representation.
        /// </summary>
        public SerializedData? Data { get; set; } = null;

        //TODO implement usage 
        public Stream Content { get; set; } = new MemoryStream();
    }

}
