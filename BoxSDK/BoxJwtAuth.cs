using Box.Schemas;
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

namespace Box
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
        public string EnterpriseId { get; private init; }

        /// <summary>
        /// The user ID to authenticate.
        /// </summary>
        public string UserId { get; private init; }

        /// <summary>
        /// Token storage
        /// </summary>
        public ITokenStorage TokenStorage { get; private init; }

        internal SubjectType SubjectType { get; init; }

        private JwtConfig(string clientId, string clientSecret, string publicKeyId, string privateKey, string privateKeyPassphrase, SubjectType subjectType, ITokenStorage? tokenStorage = default)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            JwtKeyId = publicKeyId;
            PrivateKey = privateKey;
            PrivateKeyPassphrase = privateKeyPassphrase;
            SubjectType = subjectType;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise from parameters.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="publicKeyId"></param>
        /// <param name="privateKey"></param>
        /// <param name="privateKeyPassphrase"></param>
        /// <param name="enterpriseId"></param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the enterprise.</returns>
        public static JwtConfig Enterprise(string clientId, string clientSecret, string publicKeyId, string privateKey, string privateKeyPassphrase, string enterpriseId, ITokenStorage? tokenStorage = default)
        {
            return new JwtConfig(clientId, clientSecret, publicKeyId, privateKey, privateKeyPassphrase, SubjectType.Enterprise) { EnterpriseId = enterpriseId, TokenStorage = tokenStorage };
        }

        /// <summary>
        /// Creates JwtConfig for User from parameters.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="publicKeyId"></param>
        /// <param name="privateKey"></param>
        /// <param name="privateKeyPassphrase"></param>
        /// <param name="userId"></param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the user.</returns>
        public static JwtConfig User(string clientId, string clientSecret, string publicKeyId, string privateKey, string privateKeyPassphrase, string userId, ITokenStorage? tokenStorage = default)
        {
            return new JwtConfig(clientId, clientSecret, publicKeyId, privateKey, privateKeyPassphrase, SubjectType.User) { UserId = userId, TokenStorage = tokenStorage };
        }

        /// <summary>
        /// Creates JwtConfig for Enteprise from Json string.
        /// </summary>
        /// <param name="jsonString">Box Jwt configuration as json</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the enterprise.</returns>
        public static JwtConfig EnterpriseFromJson(string jsonString, ITokenStorage? tokenStorage = default)
        {
            return FromConfigJsonString(jsonString, "", tokenStorage);
        }

        /// <summary>
        /// Creates JwtConfig for User from Json string.
        /// </summary>
        /// <param name="jsonString">Box Jwt configuration as json.</param>
        /// <param name="userId">User ID used to authenticate.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the user.</returns>
        public static JwtConfig UserFromJson(string jsonString, string userId, ITokenStorage? tokenStorage = default)
        {
            return FromConfigJsonString(jsonString, userId, tokenStorage);
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise from Json Stream. Can be used e.g with FileStream.
        /// </summary>
        /// <param name="configStream">Box Jwt configuration as stream.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the enterprise.</returns>
        public static JwtConfig EnterpriseFromJsonStream(Stream configStream, ITokenStorage? tokenStorage = default)
        {
            return FromConfigFile(configStream, "", tokenStorage);
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise from Json Stream. Can be used e.g with FileStream.
        /// </summary>
        /// <param name="configStream">Box Jwt configuration as stream.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for the user.</returns>
        public static JwtConfig UserFromJsonStream(Stream configStream, string userId, ITokenStorage? tokenStorage = default)
        {
            return FromConfigFile(configStream, userId, tokenStorage);
        }

        /// <summary>
        /// Creates JwtConfig for Enterprise or User depending of parameters provided from json.
        /// </summary>
        /// <param name="jsonString">Box Jwt configuration as json.</param>
        /// <param name="userId">The user ID to authenticate.</param>
        /// <param name="tokenStorage"></param>
        /// <returns>A JwtConfig for either user or enterprise.</returns>
        public static JwtConfig FromConfigJsonString(string jsonString, string userId = "", ITokenStorage? tokenStorage = default)
        {
            var json = JsonNode.Parse(jsonString);
            string? clientId = "", clientSecret = "", privateKey = "", passPhrase = "", publicKeyId = "";

            var boxAppSettings = json?["boxAppSettings"];
            if (boxAppSettings != null)
            {
                clientId = boxAppSettings["clientID"]?.ToString();

                clientSecret = boxAppSettings["clientSecret"]?.ToString();

                var appAuth = boxAppSettings["appAuth"];

                if (appAuth != null)
                {
                    privateKey = appAuth["privateKey"]?.ToString();

                    passPhrase = appAuth["passphrase"]?.ToString();

                    publicKeyId = appAuth["publicKeyID"]?.ToString();
                }
            }

            var enterpriseId = json?["enterpriseID"]?.ToString();

            tokenStorage = tokenStorage ?? new InMemoryTokenStorage();

            return !string.IsNullOrEmpty(userId) ?
                User(clientId, clientSecret, publicKeyId, privateKey, passPhrase, userId, tokenStorage) :
                Enterprise(clientId, clientSecret, publicKeyId, privateKey, passPhrase, enterpriseId, tokenStorage);
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
                return FromConfigJsonString(jsonString, userId);
            }
        }
    }

    enum SubjectType
    {
        User,
        Enterprise
    }

    static class SubjectTypeExtensions
    {
        public static string AsString(this SubjectType subType)
        {
            switch (subType)
            {
                case SubjectType.User:
                    return "user";
                case SubjectType.Enterprise:
                    return "enterprise";
                default:
                    throw new ArgumentException($"Unknown Subject type: {subType}");
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
    public class BoxJwtAuth : IAuth
    {
        ITokenStorage _tokenStorage { get; set; }
        bool _needsRefresh { get; set; } = true;

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

            _subjectType = Config.SubjectType;

            _subjectId = Config.SubjectType == SubjectType.Enterprise ? config.EnterpriseId : config.UserId;

            _tokenStorage = Config.TokenStorage;

            _signingCredentials = GetSigningCredentials();
        }

        /// <summary>
        /// Used to switch Auth to authenticate as enterprise.
        /// </summary>
        /// <param name="enterpriseId">Box EnterpriseID used for authentication.</param>
        public async System.Threading.Tasks.Task AsEnterpriseAsync(string enterpriseId)
        {
            _subjectType = SubjectType.Enterprise;
            _subjectId = enterpriseId;
            await MarkForRefreshAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Used to switch Auth to authenticate as user.
        /// </summary>
        /// <param name="userId">Box UserID used for authentication.</param>
        public async System.Threading.Tasks.Task AsUserAsync(string userId)
        {
            _subjectType = SubjectType.User;
            _subjectId = userId;
            await MarkForRefreshAsync().ConfigureAwait(false);
        }

        private async System.Threading.Tasks.Task MarkForRefreshAsync()
        {
            await _tokenStorage.ClearAsync().ConfigureAwait(false);
            _needsRefresh = true;
        }

        private async System.Threading.Tasks.Task SetTokenAsync(AccessToken token)
        {
            await _tokenStorage.StoreAsync(token).ConfigureAwait(false);
            _needsRefresh = false;
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
            if (_needsRefresh)
            {
                return await RefreshTokenAsync().ConfigureAwait(false);
            }
            return await _tokenStorage.GetAsync().ConfigureAwait(false);
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
                Body = SimpleJsonSerializer.Serialize(payload),
                ContentType = ContentTypes.FormUrlEncoded,
            }).ConfigureAwait(false);

            var newToken = SimpleJsonSerializer.Deserialize<AccessToken>(response.Text);
            await SetTokenAsync(newToken).ConfigureAwait(false);
            return newToken;
        }
    }
}
