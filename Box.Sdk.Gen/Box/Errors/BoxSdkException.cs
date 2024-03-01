using System;

namespace Errors
{
    public class BoxSdkException : Exception
    {
        public System.DateTimeOffset? Timestamp { get; set; } = default;

        public string? Error { get; set; } = default;

        public string Name { get; set; }

        public BoxSdkException(string message, DateTimeOffset? timeStamp = null, string name = "BoxSdkException") : base(message)
        {
            Name = name;
            Timestamp = timeStamp ?? DateTimeOffset.UtcNow;
        }
    }
}