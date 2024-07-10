using System.IO;

namespace Box.Sdk.Gen.Internal
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
