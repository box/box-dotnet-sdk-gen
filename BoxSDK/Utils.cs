using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Box
{
    /// <summary>
    /// Class for various utilities functions used in SDK.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gets environment variable.
        /// </summary>
        /// <param name="name">Name of the environment variable.</param>
        /// <returns>A environment variable</returns>
        public static string? GetEnvVar(string name) => Environment.GetEnvironmentVariable(name);

        /// <summary>
        /// Generates GUID.
        /// </summary>
        /// <returns>A GUID.</returns>
        public static string GetUUID() => Guid.NewGuid().ToString();

        /// <summary>
        /// Decodes base64 string
        /// </summary>
        /// <param name="value">Base64 string.</param>
        /// <returns>A decoded base64 string.</returns>
        public static string DecodeBase64(string value) => System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(value));

        /// <summary>
        /// Returns string representation of an object.
        /// </summary>
        /// <param name="obj">Object class.</param>
        /// <returns>A string representation of an object.</returns>
        public static string? ToString<T>(T? obj) => obj?.ToString();

        /// <summary>
        /// Remove empty entries from dictionary. Used for headers and query params.
        /// </summary>
        /// <param name="dict">Input dictionary.</param>
        /// <returns>Dictionary without empty entries.</returns>
        public static Dictionary<string, string> PrepareParams(Dictionary<string, string?> dict) =>
            dict.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(pair => pair.Key, pair => pair.Value!);

        /// <summary>
        /// Creates MemoryStream of given size and fills it with random data.
        /// </summary>
        /// <param name="size">Size of MemoryStream.</param>
        /// <returns>MemoryStream.</returns>
        public static Stream GenerateByteStream(int size)
        {
            var buffer = new byte[size];
            new Random().NextBytes(buffer);
            return new MemoryStream(buffer);
        }

        /// <summary>
        /// Creates Byte Array of given size with random values.
        /// </summary>
        /// <param name="size">Size of byte array.</param>
        /// <returns>byte array.</returns>
        public static byte[] GenerateByteBuffer(int size)
        {
            var buffer = new byte[size];
            new Random().NextBytes(buffer);
            return buffer;
        }

        /// <summary>
        /// Creates MemoryStream from byte array.
        /// </summary>
        /// <param name="buffer">byte array.</param>
        /// <returns>MemoryStream.</returns>
        public static Stream GenerateByteStreamFromBuffer(byte[] buffer) => new MemoryStream(buffer);

        /// <summary>
        /// Creates MemoryStream from Base64 encoded string.
        /// </summary>
        /// <param name="data">Base64 encoded string.</param>
        /// <returns>MemoryStream.</returns>
        public static Stream DecodeBase64ByteStream(string data) => new MemoryStream(Convert.FromBase64String(data));

        /// <summary>
        /// Creates byte array from Stream
        /// </summary>
        /// <param name="byteStream">Stream.</param>
        /// <returns>byte array.</returns>
        public static async System.Threading.Tasks.Task<byte[]> ReadByteStreamAsync(Stream byteStream)
        {
            using var memoryStream = new MemoryStream();
            await byteStream.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }

        /// <summary>
        /// Checks if two byte arrays are equal.
        /// </summary>
        /// <param name="buffer1">First byte array.</param>
        /// <param name="buffer2">Second byte array.</param>
        /// <returns>True if byte arrays are equals, otherwise false.</returns>
        public static bool BufferEquals(byte[] buffer1, byte[] buffer2) => buffer1.SequenceEqual(buffer2);

        /// <summary>
        /// Creates a cancellation token that will be cancelled after a given delay in ms.
        /// </summary>
        /// <param name="delay">Delay in ms</param>
        /// <returns>Cancellation token</returns>
        public static CancellationToken CreateTokenAndCancelAfter(int delay)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(delay);
            return cancellationTokenSource.Token;
        }
    }
}
