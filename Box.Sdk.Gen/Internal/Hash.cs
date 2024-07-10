using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Box.Sdk.Gen.Internal
{
    [JsonConverter(typeof(StringEnumConverter<HashName>))]
    internal enum HashName
    {
        [Description("sha1")]
        Sha1
    }

    class Hash
    {
        internal HashAlgorithm HashAlgorithm { get; }
        internal HashName Algorithm { get; }
        internal byte[]? Data { get; private set; }

        internal Hash(HashName algorithm)
        {
            switch (algorithm)
            {
                case HashName.Sha1:
                    Algorithm = algorithm;
                    break;
                default:
                    throw new ArgumentException($"Provided hash algorithm {algorithm} not supported");
            }
        }

        internal async Task<string> DigestHashAsync(string encoding)
        {
            if (Data == null)
            {
                throw new ArgumentException("Data part of Hash is empty");
            }
            using (var sha1 = SHA1.Create())
            {
                return await Task.FromResult(Convert.ToBase64String(sha1.ComputeHash(Data)));
            }
        }

        internal void UpdateHash(byte[] data)
        {
            Data = Data == null ? data : Data.Concat(data).ToArray();
        }
    }

}
