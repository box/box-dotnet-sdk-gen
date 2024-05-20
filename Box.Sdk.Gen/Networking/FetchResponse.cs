using System.IO;
using Serializer;
using Serialization.Json;

namespace Fetch
{
    /// <summary>
    /// Result of a Fetch call.
    /// </summary>
    class FetchResponse
    {
        /// <summary>
        /// Status code of a response.
        /// </summary>
        internal int Status { get; init; }

        /// <summary>
        /// Response text representation.
        /// </summary>
        internal SerializedData? Data { get; init; }

        //TODO implement usage 
        internal Stream Content { get; init; } = new MemoryStream();
    }

}
