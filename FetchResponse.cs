using System.IO;
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
        public int Status { get; init; }

        /// <summary>
        /// Response text representation.
        /// </summary>
        public string Text { get; init; }
        
        //TODO implement usage 
        public Stream Content { get; init; }
    }

}
