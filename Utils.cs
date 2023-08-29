using System;
using System.Collections.Generic;
using System.Linq;

namespace Box {
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
    }
}
