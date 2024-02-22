using Serialization.Json;
using Serializer;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Box.Sdk.Gen
{
    /// <summary>
    /// Class for various json utilities functions used in SDK.
    /// </summary>
    public static class JsonUtils
    {
        /// <summary>
        /// Converts Json string to SerializedData.
        /// </summary>
        /// <param name="text">json string</param>
        /// <returns>Serialized Data</returns>
        public static SerializedData JsonToSerializedData(string text)
        {
            return new SerializedData(text, true);
        }

        /// <summary>
        /// Converts SerializedData to Json string representation.
        /// </summary>
        /// <param name="data">SerializedData</param>
        /// <returns>Json string</returns>
        public static string SdToJson(SerializedData data)
        {
            return data.AsJson();
        }

        /// <summary>
        /// Converts SerializedData to Url params representation.
        /// </summary>
        /// <param name="data">SerializedData</param>
        /// <returns>Url params as string</returns>
        public static string SdToUrlParams(SerializedData data)
        {
            //TODO typecheck
            var parameters = SimpleJsonSerializer.Deserialize<Dictionary<string, string>>(data);
            return string.Join('&',
                   parameters.Select(q => $"{HttpUtility.UrlEncode(q.Key)}={HttpUtility.UrlEncode(q.Value)}"));
        }
    }
}
