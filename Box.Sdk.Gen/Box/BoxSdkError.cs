using System;

namespace Errors
{
    public class BoxSdkError : Exception {

        public System.DateTimeOffset? Timestamp { get; set; } = default;

        public string? Error { get; set; } = default;

        public string Name { get; set; }

        public BoxSdkError(string message, string name = "BoxSdkError") : base(message) {
            Name = name;
        }
    }
}