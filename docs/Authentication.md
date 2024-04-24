# Authentication

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Authentication methods](#authentication-methods)
  - [Developer Token](#developer-token)
  - [Client Credentials Grant](#client-credentials-grant)
    - [Obtaining Service Account token](#obtaining-service-account-token)
    - [Obtaining User token](#obtaining-user-token)
    - [Switching between Service Account and User](#switching-between-service-account-and-user)
  - [OAuth 2.0 Auth](#oauth-20-auth)
- [Revoke token](#revoke-token)
- [Downscope token](#downscope-token)
- [Token storage](#token-storage)
  - [In-memory token storage](#in-memory-token-storage)
  - [Custom storage](#custom-storage)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# Authentication methods

## Developer Token

The fastest way to get started using the API is with developer token. A
developer token is simply a short-lived access token that cannot be refreshed
and can only be used with your own account. Therefore, they're only useful for
testing an app and aren't suitable for production. You can obtain a developer
token from your application's [developer console][dev_console] page.

To create a `BoxClient` with a developer token, construct an `BoxDeveloperTokenAuth`
object with the `token` set to the developer token and construct the client with that.

<!-- sample x_auth init_with_dev_token -->

```c#
using Box.Sdk.Gen;

var auth = new BoxDeveloperTokenAuth(token: "DEVELOPER_TOKEN_GOES_HERE");
var client = new BoxClient(auth: auth));

var me = await client.Users.GetUserMeAsync();
Console.WriteLine($"My user ID is {me.Id}");
```

[dev_console]: https://app.box.com/developers/console

## Client Credentials Grant

Before using Client Credentials Grant Auth make sure you set up correctly your Box App.
The guide with all required steps can be found here: [Setup with Client Credentials Grant][ccg_guide]

Client Credentials Grant Auth method allows you to obtain an access token by having client credentials
and secret with enterprise or user ID, which allows you to work using service or user account.

You can use `BoxCcgAuth` to initialize a client object the same way as for other authentication types:

```c#
using Box.Sdk.Gen;

var config = new CcgConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", userId: "YOUR_USER_ID");
var auth = new BoxCcgAuth(config: config);
var client = new BoxClient(auth: auth);

var me = await client.Users.GetUserMeAsync();
Console.WriteLine($"My user ID is {me.Id}"));
```

Obtained token is valid for specified amount of time, it will be refreshed automatically by default.

### Obtaining Service Account token

The [Service Account](https://developer.box.com/guides/getting-started/user-types/service-account//)
is separate from the Box accounts of the application developer and the
enterprise admin of any enterprise that has authorized the app — files stored in that account
are not accessible in any other account by default, and vice versa.
To obtain service account you will have to provide enterprise ID with client id and secret:

```c#
using Box.Sdk.Gen;

var config = new CcgConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", enterpriseId: "YOUR_ENTERPRISE_ID");
var auth = new BoxCcgAuth(config: config);
var client = new BoxClient(auth: auth);

var auth = new BoxCcgAuth(config: config);
var client = new BoxClient(auth: auth);
```

### Obtaining User token

In order to enable obtaining user token you have to go to your application configuration that can be found
[here][dev_console]. In `Configuration` tab, in section `Advanced Features`
select `Generate user access tokens`. Do not forget to re-authorize application if it was already authorized.

To obtain user account you will have to provide user ID with client id and secret.

```c#
using Box.Sdk.Gen;

var config = new CcgConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", userId: "YOUR_USER_ID");
var auth = new BoxCcgAuth(config: config);
var client = new BoxClient(auth: auth);
```

### Switching between Service Account and User

In order to switch between being authenticated as Service Account and a User you can call:

```c#
await auth.WithEnterpriseSubjectAsync(enterpriseId: "YOUR_ENTERPRISE_ID");
```

to authenticate as enterprise or

```c#
await auth.WithUserSubjectAsync(userId: "YOUR_USER_ID");
```

to authenticate as User with provided ID. The new token will be automatically fetched with a next API call.

[ccg_guide]: https://developer.box.com/guides/authentication/client-credentials/client-credentials-setup/

## OAuth 2.0 Auth

If your application needs to integrate with existing Box users who will provide
their login credentials to grant your application access to their account, you
will need to go through the standard OAuth2 login flow. A detailed guide for
this process is available in the
[Authentication with OAuth API documentation](https://developer.box.com/en/guides/authentication/oauth2/).

Using an auth code is the most common way of authenticating with the Box API for
existing Box users, to integrate with their accounts.
Your application must provide a way for the user to login to Box (usually with a
browser or web view) in order to obtain an auth code.

<!-- sample get_authorize -->

```c#
using Box.Sdk.Gen;

var config = new OAuthConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET");
var auth = new BoxOAuth(config: config);

// the URL to redirect the user to
var authorizeUrl = auth.GetAuthorizeUrl();
```

After a user logs in and grants your application access to their Box account,
they will be redirected to your application's `redirect_uri` which will contain
an auth code. This auth code can then be used along with your client ID and
client secret to establish an API connection.
You need to provide the auth code to the SDK to obtain an access token, then you can use the SDK as usual.

<!-- sample post_oauth2_token --->

```c#
await auth.GetTokensAuthorizationCodeGrantAsync("code");
```

# Revoke token

Access tokens for a client can be revoked when needed. This call invalidates old token.
For BoxCcgAuth and BoxJwtAuth you can still reuse the `auth` object to retrieve a new token.
If you make any new call after revoking the token, a new token will be automatically retrieved.
For BoxOAuth it would be necessary to manually go through the authentication process again.
For BoxDeveloperTokenAuth, it is necessary to provide a DeveloperTokenConfig during initialization,
containing the client ID and client secret.

To revoke current client's tokens in the storage use the following code:

<!-- sample post_oauth2_revoke -->

```c#
await auth.RevokeTokenAsync();
```

# Downscope token

You can exchange a client's access token for one with a lower scope, in order
to restrict the permissions for a child client or to pass to a less secure
location (e.g. a browser-based app).

A downscoped token does not include a refresh token.
In such a scenario, to obtain a new downscoped token, refresh the original token
and utilize the newly acquired token to obtain the downscoped token.

More information about downscoping tokens can be found [here](https://developer.box.com/guides/authentication/tokens/downscope/).
If you want to learn more about available scopes please go [here](https://developer.box.com/guides/api-calls/permissions-and-errors/scopes/#scopes-for-downscoping).

For example to get a new token with only `item_preview` scope, restricted to a single file, suitable for the
[Content Preview UI Element](https://developer.box.com/en/guides/embed/ui-elements/preview/) you can use the following code.
You can also initialize `BoxDeveloperTokenAuth` with the retrieved access token and use it to create a new Client.

<!-- sample post_oauth2_token downscope_token -->

```c#
using Box.Sdk.Gen;

resourcePath = 'https://api.box.com/2.0/files/123456789'
AccessToken downscopedToken = await auth.DownscopeTokenAsync(
  scopes: Array.AsReadOnly(new [] {"item_rename","item_preview"}), resource: resourcePath
);

BoxClient downscopedClient = new BoxClient(auth: new BoxDeveloperTokenAuth(token: downscopedToken.AccessTokenField));
```

# Token storage

## In-memory token storage

By default, the SDK stores the access token in volatile memory. When rerunning your application,
the access token won't be reused from the previous run; a new token has to be obtained again.
To use in-memory token storage, you don't need to do anything more than
create an Auth class using AuthConfig, for example, for BoxOAuth:

```c#
using Box.Sdk.Gen;

var config = new OAuthConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET");
var auth = new BoxOAuth(config: config);
```

## Custom storage

You can also provide a custom token storage class. All you need to do is create a class that inherits from `TokenStorage`
and implements all of its abstract methods. Then, pass an instance of your class to the AuthConfig constructor.

```c#
using Box.Sdk.Gen;

var config = new OAuthConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", tokenStorage: new MyCustomTokenStorage());
var auth = new BoxOAuth(config: config)
```
