using System;

namespace Errors
{
    public class BoxApiException : BoxSdkException
    {
        public RequestInfo RequestInfo { get; set; }

        public ResponseInfo ResponseInfo { get; set; }

        public BoxApiException(string message, DateTimeOffset timeStamp, RequestInfo requestInfo, ResponseInfo responseInfo) : base(message, timeStamp, "BoxApiException")
        {
            RequestInfo = requestInfo;
            ResponseInfo = responseInfo;
        }
    }
}