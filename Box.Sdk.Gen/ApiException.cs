using System;

namespace Fetch
{
    /// <summary>
    /// Class representing exception caused most likely by the Http/s request.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Status code of the Http/s response.
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Http/s response in a string format.
        /// </summary>
        public string ApiResponse { get; }

        /// <summary>
        /// Instantiates a new ApiException with the default message
        /// </summary>
        /// <param name="statusCode">Status code returned from the api</param>
        /// <param name="apiResponse">Response returned from the api</param>
        public ApiException(int statusCode, string apiResponse)
            : base(BaseErrorMessage(statusCode, apiResponse))
        {
            StatusCode = statusCode;
            ApiResponse = apiResponse;
        }

        /// <summary>
        /// Instantiates a new ApiException with the provided message
        /// </summary>
        /// <param name="statusCode">Status code returned from the api</param>
        /// <param name="apiResponse">Response returned from the api</param>
        /// <param name="message">Custom error message</param>
        public ApiException(int statusCode, string apiResponse, string message)
            : base(message)
        {
            StatusCode = statusCode;
            ApiResponse = apiResponse;
        }
        internal static string BuildApiExceptionMessage(int statusCode, string apiResponse, string? message = null)
        {
            return message != null ?
                string.Join(Environment.NewLine, message, BaseErrorMessage(statusCode, apiResponse)) :
                BaseErrorMessage(statusCode, apiResponse);
        }

        private static string BaseErrorMessage(int statusCode, string apiResponse)
            => $"Api returned an error status code. Status code: {statusCode}, API response: {apiResponse}";
    }
}
