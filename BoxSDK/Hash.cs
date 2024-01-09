using Serializer;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Box
{
    [JsonConverter(typeof(StringEnumConverter<HashName>))]
    public enum HashName
    {
        [Description("sha1")]
        Sha1
    }

    public class Hash
    {
        public HashAlgorithm HashAlgorithm { get; }
        public HashName Algorithm { get; }
        public byte[]? Data { get; private set; }

        public Hash(HashName algorithm)
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

        public async Task<string> DigestHashAsync(string encoding)
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

        public void UpdateHash(byte[] data)
        {
            Data = Data == null ? data : Data.Concat(data).ToArray();
        }
    }

}
