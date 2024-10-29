using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Asymmetric;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Operators;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Box.Sdk.Gen.Internal
{
    /// <summary>
    /// Class for various jwt utilities functions used in SDK.
    /// </summary>
    static class JwtUtils
    {
        /// <summary>
        /// Create jwt assertion.
        /// </summary>JwtSignOptions
        /// <param name="claims">Jwt claims</param>
        /// <param name="key">Jwt key</param>
        /// <param name="options">Jwt sign options</param>
        /// <returns>Jwt assertion</returns>
        internal static string CreateJwtAssertion(Dictionary<string, object> claims, JwtKey key, JwtSignOptions options)
        {
            var jwtClaims = claims.Select(x => new Claim(x.Key, x.Value.ToString()!)).ToList();

            var randomNumber = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }

            jwtClaims.Add(new Claim("jti", Convert.ToBase64String(randomNumber)));
            jwtClaims.Add(new Claim("sub", options.Subject));

            var expClaim = claims["exp"].ToString();
            if (string.IsNullOrEmpty(expClaim))
            {
                throw new BoxSdkException("Exp claim cannot be empty");
            }

            var expTime = long.Parse(expClaim);

            var jwtPayload = new JwtPayload(options.Issuer, options.Audience,
                jwtClaims, null, DateTimeOffset.FromUnixTimeSeconds(expTime).LocalDateTime);

            var signingCredentials = GetSigningCredentials(key);

            var header = new JwtHeader(signingCredentials);

            var token = new JwtSecurityToken(header, jwtPayload);
            var assertion = new JwtSecurityTokenHandler().WriteToken(token);

            return assertion;
        }

        private static SigningCredentials GetSigningCredentials(JwtKey key)
        {
            using (var keyReader = new StringReader(key.Key))
            {
                var reader = new OpenSslPemReader(keyReader);
                var privateCrtKeyParams = reader.ReadObject();

                if (privateCrtKeyParams == null)
                {
                    throw new ArgumentException("Invalid private JWT key!");
                }

                if (privateCrtKeyParams is Pkcs8EncryptedPrivateKeyInfo)
                {
                    var pkcs8 = (Pkcs8EncryptedPrivateKeyInfo)privateCrtKeyParams;
                    PrivateKeyInfo privateKeyInfo = pkcs8.DecryptPrivateKeyInfo(
                new PkixPbeDecryptorProviderBuilder().Build(key.Passphrase.ToCharArray()));
                    var bcKey = AsymmetricKeyFactory.CreatePrivateKey(privateKeyInfo.GetEncoded());

                    if (bcKey is AsymmetricRsaPrivateKey)
                    {
                        var bcRsaKey = (AsymmetricRsaPrivateKey)bcKey;
                        var rsaParams = ToRSAParameters(bcRsaKey);
                        var rsaKey = new RsaSecurityKey(rsaParams);

                        return new SigningCredentials(rsaKey, SecurityAlgorithms.RsaSha256);
                    }
                }

                throw new ArgumentException("Provided JWT Key format is not supported");
            }
        }

        private static RSAParameters ToRSAParameters(AsymmetricRsaPrivateKey privateKey)
        {
            RSAParameters rp = new RSAParameters();
            rp.Modulus = privateKey.Modulus.ToByteArrayUnsigned();
            rp.Exponent = privateKey.PublicExponent.ToByteArrayUnsigned();
            rp.P = privateKey.P.ToByteArrayUnsigned();
            rp.Q = privateKey.Q.ToByteArrayUnsigned();
            rp.D = ConvertRSAParametersField(privateKey.PrivateExponent, rp.Modulus.Length);
            rp.DP = ConvertRSAParametersField(privateKey.DP, rp.P.Length);
            rp.DQ = ConvertRSAParametersField(privateKey.DQ, rp.Q.Length);
            rp.InverseQ = ConvertRSAParametersField(privateKey.QInv, rp.Q.Length);
            return rp;
        }

        private static byte[] ConvertRSAParametersField(Org.BouncyCastle.Math.BigInteger n, int size)
        {
            byte[] bs = n.ToByteArrayUnsigned();
            if (bs.Length == size)
            {
                return bs;
            }

            if (bs.Length > size)
            {
                throw new ArgumentException("Specified size too small", "size");
            }

            byte[] padded = new byte[size];
            Array.Copy(bs, 0, padded, size - bs.Length, bs.Length);
            return padded;
        }
    }

    enum JwtAlgorithm
    {
        Rs256
    }

    class JwtKey
    {
        internal string Key { get; }
        internal string Passphrase { get; }

        public JwtKey(string key, string passphrase)
        {
            Key = key;
            Passphrase = passphrase;
        }
    }

    class JwtSignOptions
    {
        internal JwtAlgorithm Algorithm { get; }
        internal string Audience { get; }
        internal string Subject { get; }
        internal string Issuer { get; }
        internal string Jwtid { get; }
        internal string Keyid { get; }

        public JwtSignOptions(JwtAlgorithm algorithm, string audience, string subject, string issuer, string jwtid, string keyid)
        {
            Algorithm = algorithm;
            Audience = audience;
            Subject = subject;
            Issuer = issuer;
            Jwtid = jwtid;
            Keyid = keyid;
        }
    }
}
