using Box.Sdk.Gen.Schemas;
using Fetch;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Serializer;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Box.Sdk.Gen
{
    /// <summary>
    /// Config used for JWT authentication
    /// </summary>
    public class JwtConfig
    {
        /// <summary>
        /// Used for identifying the application the user is authenticating with.
        /// </summary>
        public string ClientId { get; }

        /// <summary>
        /// Box API secret used for making auth requests.
        /// </summary>
        public string ClientSecret { get; }

        /// <summary>
        /// Public key ID used to create JWT assertion.
        /// </summary>
        public string JwtKeyId { get; }

        /// <summary>
        /// RSA private key used to create JWT assertion.
        /// </summary>
        public string PrivateKey { get; }

        /// <summary>
        /// Passphrase used to access PrivateKey.
        /// </summary>
        public string PrivateKeyPassphrase { get; }

        /// <summary>
        /// The ID of the Box Developer Edition enterprise.
        /// </summary>
        public string? EnterpriseId { get; private init; }

        /// <summary>
        /// The user ID to authenticate.
        /// </summary>
        public string? UserId { get; private init; }

        /// <summary>
        /// Token storage.
        /// </summary>
        public ITokenStorage TokenStorage { get; private init; }

        /// <summary>
        /// Creates JwtConfig based on provided parameters.
        /// </summary>
        /// <param name="clientId">Used for identifying the application the user is authenticating with.</param>
        /// <param name="clientSecret">Box API secret used for making auth requests.</param>
        /// <param name="publicKeyId">Public key ID used to create JWT assertion.</param>
        /// <param name="privateKey">RSA private key used to create JWT assertion.</param>
        /// <param name="privateKeyPassphrase">Passphrase used to access PrivateKey.</param>
        /// <param name="userId">The user ID to authenticate.</param>
        /// <param name="enterpriseId">The ID of the Box Developer Edition enterprise.</param>
        /// <param name="tokenStorage">Token storage. Defaulted to InMemoryTokenStorage.</param>
        /// <returns>A JwtConfig for either user or enterprise.</returns>
        public JwtConfig(string clientId, string clientSecret, string publicKeyId, string privateKey, string privateKeyPassphrase, string? userId = default, string? enterpriseId = default, ITokenStorage? tokenStorage = default)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            JwtKeyId = publicKeyId;
            PrivateKey = privateKey;
            PrivateKeyPassphrase = privateKeyPassphrase;
            UserId = userId;
            EnterpriseId = enterpriseId;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise or User depending of parameters provided from json.
        /// </summary>
        /// <param name="configJsonString">Box Jwt configuration as json.</param>
        /// <param name="userId">The user ID to authenticate.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for either user or enterprise.</returns>
        public static JwtConfig FromConfigJsonString(string configJsonString, string userId = "", ITokenStorage? tokenStorage = default)
        {
            var json = JsonNode.Parse(configJsonString);
            string? clientId = "", clientSecret = "", privateKey = "", privateKeyPassphrase = "", publicKeyId = "";

            var boxAppSettings = json?["boxAppSettings"];
            if (boxAppSettings != null)
            {
                clientId = boxAppSettings["clientID"]?.ToString();

                clientSecret = boxAppSettings["clientSecret"]?.ToString();

                var appAuth = boxAppSettings["appAuth"];

                if (appAuth != null)
                {
                    privateKey = appAuth["privateKey"]?.ToString();

                    privateKeyPassphrase = appAuth["passphrase"]?.ToString();

                    publicKeyId = appAuth["publicKeyID"]?.ToString();
                }
            }

            var enterpriseId = json?["enterpriseID"]?.ToString();

            tokenStorage = tokenStorage ?? new InMemoryTokenStorage();

            return new JwtConfig(clientId, clientSecret, publicKeyId, privateKey, privateKeyPassphrase, userId, enterpriseId, tokenStorage);
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise or User depending of parameters provided from Json Stream. Can be used e.g with FileStream.
        /// </summary>
        /// <param name="configStream">Box Jwt configuration as stream.</param>
        /// <param name="userId">User ID used to authenticate.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the user.</returns>
        public static JwtConfig FromConfigFile(Stream configStream, string userId = "", ITokenStorage? tokenStorage = default)
        {
            using (var reader = new StreamReader(configStream, Encoding.UTF8))
            {
                var jsonString = reader.ReadToEnd();
                return FromConfigJsonString(jsonString, userId, tokenStorage);
            }
        }
    }

    static class JwtGrantType
    {
        public const string JWTAuthorizationCode = "urn:ietf:params:oauth:grant-type:jwt-bearer";
    }

    /// <summary>
    /// Class used to authenticate with Box using JWT.
    /// </summary>
    public class BoxJwtAuth : IAuthentication
    {
        ITokenStorage _tokenStorage { get; set; }
        /// <summary>
        /// Box Jwt configuration.
        /// </summary>
        public JwtConfig Config { get; }

        string _subjectId { get; set; }
        SubjectType _subjectType { get; set; }
        SigningCredentials _signingCredentials { get; }

        /// <summary>
        /// Creates BoxJwtAuth from JwtConfig.
        /// </summary>
        /// <param name="config">Jwt configuration.</param>
        public BoxJwtAuth(JwtConfig config)
        {
            Config = config;

            if (!string.IsNullOrEmpty(config.UserId))
            {
                _subjectId = config.UserId;
                _subjectType = SubjectType.User;
            }
            else if (!string.IsNullOrEmpty(config.EnterpriseId))
            {
                _subjectId = config.EnterpriseId;
                _subjectType = SubjectType.Enterprise;
            }
            else
            {
                throw new ArgumentException("Could not find either UserId or EnterpriseId in the configuration.");
            }

            _tokenStorage = Config.TokenStorage;

            _signingCredentials = GetSigningCredentials();
        }

        /// <summary>
        /// Used to switch Auth to authenticate as enterprise.
        /// </summary>
        /// <param name="userId">Box EnterpriseID used for authentication.</param>
        public async System.Threading.Tasks.Task AsEnterpriseAsync(string userId)
        {
            _subjectType = SubjectType.Enterprise;
            _subjectId = userId;
            await _tokenStorage.ClearAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Used to switch Auth to authenticate as user.
        /// </summary>
        /// <param name="userId">Box UserID used for authentication.</param>
        public async System.Threading.Tasks.Task AsUserAsync(string userId)
        {
            _subjectType = SubjectType.User;
            _subjectId = userId;
            await _tokenStorage.ClearAsync().ConfigureAwait(false);
        }

        private SigningCredentials GetSigningCredentials()
        {
            using (var keyReader = new StringReader(Config.PrivateKey))
            {
                var reader = new PemReader(keyReader, new PasswordFinder(Config.PrivateKeyPassphrase));
                var privateCrtKeyParams = reader.ReadObject() as RsaPrivateCrtKeyParameters;

                if (privateCrtKeyParams == null)
                {
                    throw new ArgumentException("Invalid private JWT key!");
                }

                var rsaParams = DotNetUtilities.ToRSAParameters(privateCrtKeyParams);

                var rsaKey = new RsaSecurityKey(rsaParams);
                rsaKey.KeyId = Config.JwtKeyId;

                return new SigningCredentials(rsaKey, SecurityAlgorithms.RsaSha256);
            }
        }

        class PasswordFinder : IPasswordFinder
        {
            private readonly string _password;

            public PasswordFinder(string password)
            {
                _password = password;
            }

            public char[] GetPassword() => _password.ToCharArray();
        }

        public async Task<AccessToken> RetrieveTokenAsync(NetworkSession? networkSession = null)
        {
            var token = await _tokenStorage.GetAsync().ConfigureAwait(false);
            if (token == null)
            {
                return await RefreshTokenAsync().ConfigureAwait(false);
            }
            return token;
        }

        public async Task<AccessToken> RefreshTokenAsync(NetworkSession? networkSession = null)
        {
            var randomNumber = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }

            var claims = new List<Claim>{
                new Claim("sub", _subjectId),
                new Claim("box_sub_type", _subjectType.AsString()),
                new Claim("jti", Convert.ToBase64String(randomNumber)),
            };

            DateTimeOffset expireTime = DateTimeOffset.UtcNow.AddSeconds(30);

            var tokenUrl = "https://api.box.com/oauth2/token";

            var jwtPayload = new JwtPayload(Config.ClientId, tokenUrl,
                claims, null, expireTime.LocalDateTime);

            var header = new JwtHeader(_signingCredentials);

            var token = new JwtSecurityToken(header, jwtPayload);
            var assertion = new JwtSecurityTokenHandler().WriteToken(token);

            var payload = new Dictionary<string, string>()
            {
                { "grant_type", JwtGrantType.JWTAuthorizationCode },
                { "assertion", assertion },
                { "client_id", Config.ClientId },
                { "client_secret", Config.ClientSecret }
            };

            var response = await HttpClientAdapter.FetchAsync(tokenUrl, new FetchOptions
            {
                Method = "POST",
                Data = SimpleJsonSerializer.Serialize(payload),
                ContentType = ContentTypes.FormUrlEncoded,
                NetworkSession = networkSession
            }).ConfigureAwait(false);

            var newToken = SimpleJsonSerializer.Deserialize<AccessToken>(response.Data);
            await _tokenStorage.StoreAsync(newToken).ConfigureAwait(false);
            return newToken;
        }
    }
}
