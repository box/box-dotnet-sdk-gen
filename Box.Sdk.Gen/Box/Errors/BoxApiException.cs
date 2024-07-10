using System;

namespace Box.Sdk.Gen
{
    public class BoxApiException : BoxSdkException
    {
        public RequestInfo RequestInfo { get; }

        public ResponseInfo ResponseInfo { get; }

        public BoxApiException(string message, DateTimeOffset timeStamp, RequestInfo requestInfo, ResponseInfo responseInfo) : base(message, timeStamp, "BoxApiException")
        {
            RequestInfo = requestInfo;
            ResponseInfo = responseInfo;
        }
    }
}