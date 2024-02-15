using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Box.Sdk.Gen
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
        /// <param name="map">Input dictionary.</param>
        /// <returns>Dictionary without empty entries.</returns>
        public static Dictionary<string, string> PrepareParams(Dictionary<string, string?> map) =>
            map.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(pair => pair.Key, pair => pair.Value!);

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

        /// <summary>
        /// Converts from hex string to base64 string.
        /// </summary>
        /// <param name="value">hex string.</param>
        /// <returns>base64 string.</returns>
        public static string HexToBase64(string value) =>
            Convert.ToBase64String(Convert.FromHexString(value));

        /// <summary>
        /// Gets length of a buffer (byte array).
        /// </summary>
        /// <param name="buffer">byte array.</param>
        /// <returns>length of a byte array.</returns>
        public static int BufferLength(byte[] buffer) => buffer.Length;

        /// <summary>
        /// Concatenates two ReadOnly lists.
        /// </summary>
        /// <param name="a">ReadOnly list.</param>
        /// <param name="b">ReadOnly list.</param>
        /// <returns>new list concatenated from a and b.</returns>
        public static IReadOnlyList<T> ListConcat<T>(IReadOnlyList<T> a, IReadOnlyList<T> b) =>
            a.Concat(b).ToArray();

        /// <summary>
        /// Reducer for a given iterator.
        /// </summary>
        /// <param name="iterator">Iterator.</param>
        /// <param name="reducer">Reducer function.</param>
        /// <param name="initialValue">initial value for the reducer.</param>
        /// <returns>result of applying reducer on iterator.</returns>
        public static async Task<U> ReduceIteratorAsync<T, U>(IEnumerable<T> iterator, Func<U, T, Task<U>> reducer, U initialValue)
        {
            var result = initialValue;
            var enumerator = iterator.GetEnumerator();

            while (enumerator.MoveNext())
            {
                result = await reducer(result, enumerator.Current).ConfigureAwait(false);
            }

            return result;
        }

        /// <summary>
        /// Iterates over a stream and yields chunks of it.
        /// </summary>
        /// <param name="stream">Stream to iterate over</param>
        /// <param name="chunkSize">Size of a chunk</param>
        /// <returns>Iteartor over a stream.</returns>
        public static IEnumerable<Stream> IterateChunks(Stream stream, long chunkSize)
        {
            int bufferSize = Convert.ToInt32(chunkSize);
            var buffer = new byte[bufferSize];
            var size = bufferSize;
            var offset = 0;

            while (true)
            {
                var partStream = new MemoryStream();

                var bytesRead = stream.Read(buffer, offset, size);

                if (bytesRead <= 0)
                    break;

                var bytesToWrite = partStream.Length + bytesRead >= chunkSize ? chunkSize - partStream.Length : bytesRead;

                partStream.Write(buffer, offset, Convert.ToInt32(bytesToWrite));
                partStream.Position = 0;

                yield return partStream;
            }
        }

        /// <summary>
        /// Converts string in ISO 8601 format to DateTimeOffset.
        /// </summary>
        /// <param name="dateTime">Input string (ISO 8601)</param>
        /// <returns>DateTimeOffset</returns>
        public static DateTimeOffset DateTimeFromString(string dateTime) => DateTimeOffset.Parse(dateTime);

        /// <summary>
        /// Converts DateTimeOffset to string in ISO 8601 format.
        /// </summary>
        /// <param name="dateTime">Input DateTimeOffset</param>
        /// <returns>String (ISO 8601)</returns>
        public static string DateTimeToString(DateTimeOffset dateTime) => string.Concat(dateTime.ToString("s", CultureInfo.InvariantCulture), "Z");

        /// <summary>
        /// Converts string in ISO 8601 format to DateOnly.
        /// </summary>
        /// <param name="date">Input string (ISO 8601)</param>
        /// <returns>DateOnly</returns>
        public static DateOnly DateFromString(string date) => DateOnly.Parse(date);

        /// <summary>
        /// Converts DateOnly to string in ISO 8601 format.
        /// </summary>
        /// <param name="date">Input DateOnly</param>
        /// <returns>String (ISO 8601)</returns>
        public static string DateToString(DateOnly date) => date.ToString("O", CultureInfo.InvariantCulture);

        /// <summary>
        /// Indicates if SDK is running in the browser.
        /// </summary>
        /// <returns>False</returns>
        public static bool IsBrowser() => false;

        /// <summary>
        /// Returns current Epoch time (Unix time) in seconds.
        /// </summary>
        /// <returns>Epoch time in seconds</returns>
        public static int GetEpochTimeInSeconds() => (int)DateTimeOffset.Now.ToUnixTimeSeconds();

        /// <summary>
        /// Reads all text in a file.
        /// </summary>
        /// <param name="filepath">Path to the file</param>
        /// <returns>Text from the file</returns>
        public static string ReadTextFromFile(string filepath) => System.IO.File.ReadAllText(filepath);
    }
}
