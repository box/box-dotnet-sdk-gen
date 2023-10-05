using Box.Schemas;
using Fetch;
using Serializer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Config used for CCG authentication
    /// </summary>
    public class CcgConfig
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
        /// The ID of the Box Developer Edition enterprise.
        /// </summary>
        public string? EnterpriseId { get; private init; }

        /// <summary>
        /// The user ID to authenticate.
        /// </summary>
        public string? UserId { get; private init; }

        /// <summary>
        /// Token storage
        /// </summary>
        public ITokenStorage TokenStorage { get; private init; }

        public CcgConfig(string clientId, string clientSecret, string? enterpriseId = null, string? userId = null, ITokenStorage? tokenStorage = default)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            EnterpriseId = enterpriseId;
            UserId = userId;
            TokenStorage = tokenStorage ?? new InMemoryTokenStorage();
        }
    }

    static class CcgGrantType
    {
        public const string ClientCredentials = "client_credentials";
    }


    /// <summary>
    /// Class used to authenticate with Box using a CCG Auth.
    /// </summary>
    public class BoxCcgAuth : IAuth
    {
        ITokenStorage _tokenStorage { get; set; }

        /// <summary>
        /// Box Ccg configuration.
        /// </summary>
        public CcgConfig Config { get; }

        string _subjectId { get; set; }
        SubjectType _subjectType { get; set; }


        /// <summary>
        /// Creates CcgAuth from parameters.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>A CCG Auth.</returns>
        public BoxCcgAuth(CcgConfig config)
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
            var payload = new Dictionary<string, string>()
            {
                { "grant_type", CcgGrantType.ClientCredentials },
                { "client_id", Config.ClientId },
                { "client_secret", Config.ClientSecret },
                { "box_subject_id", _subjectId },
                { "box_subject_type", _subjectType.AsString() }
            };

            var tokenUrl = "https://api.box.com/oauth2/token";

            var response = await HttpClientAdapter.FetchAsync(tokenUrl, new FetchOptions
            {
                Method = "POST",
                Body = SimpleJsonSerializer.Serialize(payload),
                ContentType = ContentTypes.FormUrlEncoded,
                NetworkSession = networkSession
            }).ConfigureAwait(false);

            var newToken = SimpleJsonSerializer.Deserialize<AccessToken>(response.Text);
            await _tokenStorage.StoreAsync(newToken).ConfigureAwait(false);
            return newToken;
        }

        /// <summary>
        /// Used to switch Auth to authenticate as enterprise.
        /// </summary>
        /// <param name="enterpriseId">Box EnterpriseID used for authentication.</param>
        public async System.Threading.Tasks.Task AsEnterpriseAsync(string enterpriseId)
        {
            _subjectType = SubjectType.Enterprise;
            _subjectId = enterpriseId;
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

    }
}
