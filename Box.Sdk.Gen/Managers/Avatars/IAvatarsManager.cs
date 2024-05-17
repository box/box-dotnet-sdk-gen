using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IAvatarsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<System.IO.Stream> GetUserAvatarAsync(string userId, GetUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UserAvatar> CreateUserAvatarAsync(string userId, CreateUserAvatarRequestBody requestBody, CreateUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteUserAvatarAsync(string userId, DeleteUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}