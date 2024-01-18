# Migration Guide: From `Box Windows V2 SDK` to `Box Dotnet SDK`

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Introduction](#introduction)
- [Installation](#installation)
- [Highlighting the Key Differences](#highlighting-the-key-differences)
  - [Nullable reference types support](#nullable-reference-types-support)
  - [Self-documenting object creation](#self-documenting-object-creation)
  - [Native cancellation token support](#native-cancellation-token-support)
  - [One package to rule them all](#one-package-to-rule-them-all)
- [Diving into Authentication](#diving-into-authentication)
  - [Developer Token](#developer-token)
  - [JWT Authentication](#jwt-authentication)
    - [Leveraging the JWT Configuration File](#leveraging-the-jwt-configuration-file)
    - [Manually Providing JWT Configuration](#manually-providing-jwt-configuration)
    - [User Authentication Simplified](#user-authentication-simplified)
  - [Client Credentials Grant](#client-credentials-grant)
    - [Service Account Token Acquisition](#service-account-token-acquisition)
    - [User Token Acquisition](#user-token-acquisition)
  - [Smooth Switching between Service Account and User](#smooth-switching-between-service-account-and-user)
  - [OAuth 2.0 Authentication](#oauth-20-authentication)
    - [Fetching the Authorization URL](#fetching-the-authorization-url)
    - [Seamless Authentication](#seamless-authentication)
  - [Customizable Token Storage](#customizable-token-storage)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

## Introduction

Welcome to the `Box DotNet SDK`, the pinnacle of Box's SDK evolution tailored for developers eager to integrate with the Box API using C# with .NET. This next-generation toolkit is meticulously crafted with contemporary development practices, ensuring an unparalleled, seamless experience.

While the `Box Windows V2 SDK` served its purpose well, the `Box DotNet SDK` elevates the experience to new heights. One of its standout features is its auto-generation directly from the Open API Specification. This guarantees that developers are always equipped with the latest Box API features, eliminating any lag or discrepancies.

This guide is your compass, offering insights and directions for a smooth migration from the legacy `Box Windows V2 SDK` to the state-of-the-art `Box DotNet SDK`. As we journey through, we'll spotlight the key differences, enhanced functionalities, and the myriad benefits that await.

For those who wish to delve deeper into the intricacies and advantages of the new SDK, the [official README](https://github.com/box/box-dotnet-sdk-gen/blob/main/README.md) is a treasure trove of information.

## Installation

Embarking on your journey with the `Box DotNet SDK` is straightforward. Here's how you can set it up:

```console
Install-Package Box.DotNet.Sdk.Gen
```

Alternatively, you can find this package in nuget and add it to your .csproj as a reference:

```xml
<ItemGroup>
  <PackageReference Include="Box.DotNet.Sdk.Gen" Version="X.Y.Z" />
</ItemGroup>
```

For those who are hesitant to make the full leap, fear not. The `Box DotNet SDK` can coexist peacefully alongside the legacy `Box Windows V2 SDK` within the same project. This coexistence offers a gentle migration path, allowing developers to transition at their own pace. However, for an optimal experience, a complete transition to the new SDK is recommended in due course.

## Highlighting the Key Differences

### Nullable reference types support

The SDK now supports [nullable reference types](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references) whenever possible. This allows to perform null state analyis and detect many problems even before the code is run.

To enable support for nullable references, enable it in your project by adding the following line to your .csproj

```xml
<Nullable>enable</Nullable>
```

When this option is enabled, a null state analysis will be performed and more information about the object will be present. Let's examine the following scenario:

```c#
var user = await client.Users.GetUserMeAsync();

// a warning is displayed: "Enterprise" may be null here. You should add a check for the null value to prevent NRE
Console.WriteLine(user.Enterprise.Id);
```

Thanks to the null state analysis, it is known that `Enterprise` part of the `user` is not always present in the object and can sometimes be set to `null`.
In this case, we need to perform an additional check to avoid the [Null Reference Exception](https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception).

```c#
var user = await client.Users.GetUserMeAsync();

// no warning now
Console.WriteLine(user.Enterprise?.Id);
```

Without nullable reference types, it would not be possible to determine which reference types could be set to null, and we would have to do it with each of them. Otherwise we would risk encountering Null Reference Exception.

### Self-documenting object creation

In the Legacy SDK `Box Windows V2 SDK` all objects exposed setters and an empty constructor. It was possible to create an object without setting some of the fields required by the API. This would result in the API error (usually Bad Request) saying that the request was missing some requeired fields. Some of the functions validated if the request fields are set properly, but even then, the lack of required fields could not be detected when call to such function was executed.

The modern `Box DotNet SDK` is designed to minimize problems with object creation and "force" the creation of objects in the correct state by utilizng constructors capabilities. Let's look at the following example

```c#
// It is not possible to create user without a name so it's a required argument of a constructor
var requestBody = new CreateUserRequestBodyArg(name: "my-test-account");
var response = await client.Users.CreateUserAsync(requestBody);
```

If a field is required by the API, it must be passed to the constructor. In other words, it's not possible to create a `CreateUserRequestBodyArg` without a name supplied as an argument to the constructor. Optional parameters can be passed using [object initializer syntax](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers).

```c#
// IsPlatformAccessOnly is not required by the API so it's passed in object initializer
var requestBody = new CreateUserRequestBodyArg(name: "my-test-account") { IsPlatformAccessOnly = true };
var response = await client.Users.CreateUserAsync(requestBody);
```

This allows for smooth, one-line and immutable object creation and it's easy to see which fields must be filled in and which are optional. Combined with the previous point about nullable reference types, it allows you to take full advantage of C#'s typing arsenal to prevent errors in your code even before the code is executed.

### Native cancellation token support

The new SDK also introduces native support for [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) for every call made to the Box API. This means that every API call can be easily cancelled and the task can be shutdown gracefully. Every API method accepts cancellation token usually as the last, optional parameter. You can use `CancellationToken` in response to your system events or as a timeout mechanism by utilizing the `CancelAfter` method.

```c#
var requestBody = new CreateUserRequestBodyArg(name: "my-test-account");
var cancellationTokenSource = new CancellationTokenSource();
var cancellationToken = cancellationTokenSource.Token;
// cancel request after 10s
cancellationTokenSource.CancelAfter(10000);

try
{
    var response = await client.Users.CreateUserAsync(requestBody, cancellationToken: cancellationToken);
}
catch (TaskCanceledException ex)
{
    //handle exception
}
```

When task is cancelled, native .NET `TaskCanceledException` is thrown.

### One package to rule them all

Legacy SDK `Box Windows V2 SDK` was distributed as a two separate packages namely `Box.V2` and `Box.V2.Core`. Adding the fact that some supported frameworks overlapped in both packages caused additional confusion for the customers, who had to decide which one was best for their projects. Additionally, the maintenance of both packages introduced developer overhead, extending the time of development for some features.

In our new generation .NET SDK `Box DotNet SDK`, we have decided to distribute one package that is designed for multiple platforms, namely `Box.DotNet.Sdk.Gen`. The determination of the best possible package match to the project in which this package is used will be delegated to the .NET platform itself. Each target platform with significiant differences will have a separate code base so that one target does not limit another. Most of the SDK is automatically generated now, so this will not cause a significant development overhead. For now, only .NET (formerly .NET Core) is supported, but .NET Framework support is planned for the future.

## Diving into Authentication

Authentication is a crucial aspect of any SDK. Let's delve into the authentication methods supported by both SDKs and understand the enhancements in the new version:

### Developer Token

The Developer Token remains a straightforward method for authentication:

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2.Auth;
using Box.Sdk.Gen.V2.Config;
using Box.Sdk.Gen.V2;

var config = new BoxConfigBuilder("YOUR_CLIENT_ID", "YOUR_CLIENT_SECRET").Build();
var session = new OAuthSession("YOUR_DEVELOPER_TOKEN", "N/A", 3600, "bearer");
var client = new BoxClient(config, session);
```

**Modern (`Box DotNet SDK`):**

The new SDK offers a more streamlined approach:

```c#
using Box.Sdk.Gen;

var auth = new BoxDeveloperTokenAuth(token: "DEVELOPER_TOKEN_GOES_HERE");
var client = new BoxClient(auth: auth);
```

### JWT Authentication

JSON Web Tokens (JWT) offer a secure method of authentication. Here's how the process has evolved:

#### Leveraging the JWT Configuration File

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2;
using Box.Sdk.Gen.V2.Config;
using Box.Sdk.Gen.V2.JWTAuth;

using var file = File.Open("/path/to/config.json", FileMode.Open, FileAccess.Read, FileShare.None);
var config = BoxConfigBuilder.CreateFromJsonFile(file).Build();
var boxJWT = new BoxJWTAuth(config);
var adminToken = await boxJWT.AdminTokenAsync();
BoxClient client = boxJWT.AdminClient(adminToken);
```

**Modern (`Box DotNet SDK`):**

The new SDK provides a more organized approach:

```c#
using Box.Sdk.Gen;

using var file = File.Open("/path/to/config.json", FileMode.Open, FileAccess.Read, FileShare.None);
var jwtConfig = JwtConfig.FromConfigFile(file);
var auth = new BoxJwtAuth(config: jwtConfig);
var client = new BoxClient(auth: auth);
```

#### Manually Providing JWT Configuration

For those who prefer manual configurations, both SDKs offer flexibility:

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2;
using Box.Sdk.Gen.V2.Config;
using Box.Sdk.Gen.V2.JWTAuth;

var boxConfig = new BoxConfigBuilder("YOUR_CLIENT_ID", "YOUR_CLIENT_SECRET", "YOUR_ENTERPRISE_ID", "YOUR_PRIVATE_KEY", "YOUR_PRIVATE_KEY_PASSPHRASE", "YOUR_KEY_ID").Build();
var boxJWT = new BoxJWTAuth(boxConfig);
var adminToken = await boxJWT.AdminTokenAsync();
BoxClient adminClient = boxJWT.AdminClient(adminToken);
```

**Modern (`Box DotNet SDK`):**

The new SDK introduces a more structured approach:

```c#
using Box.Sdk.Gen;

var jwtConfig = new JwtConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", enterpriseId: "YOUR_ENTERPRISE_ID",
  privateKey: "YOUR_PRIVATE_KEY", privateKeyPassphrase: "YOUR_PRIVATE_KEY_PASSPHRASE", publicKeyId: "YOUR_KEY_ID");
var auth = new BoxJwtAuth(config: jwtConfig);
var client = new BoxClient(auth: auth);
```

#### User Authentication Simplified

Authenticating as a user has been made even more straightforward:

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2;
using Box.Sdk.Gen.V2.Config;
using Box.Sdk.Gen.V2.JWTAuth;

var userToken = await boxJWT.UserTokenAsync("USER_ID");
var userClient = boxJWT.UserClient(userToken, "YOUR_USER_ID");
```

**Modern (`Box DotNet SDK`):**

The new SDK makes this method more organised:

```c#
using Box.Sdk.Gen;

await auth.AsUserAsync("USER_ID");
var userClient = new BoxClient(auth: auth);
```

### Client Credentials Grant

The Client Credentials Grant method is a popular choice for many developers. Let's see how it's been enhanced:

#### Service Account Token Acquisition

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2.CCGAuth;
using Box.Sdk.Gen.V2.Config;

var boxConfig = new BoxConfigBuilder(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET")
                .SetEnterpriseId("YOUR_ENTERPRISE_ID")
                .Build();
var boxCCG = new BoxCCGAuth(boxConfig);
var adminToken = await boxCCG.AdminTokenAsync();
var adminClient = boxCCG.AdminClient(adminToken: adminToken);
```

**Modern (`Box DotNet SDK`):**

The new SDK offers a more organized structure:

```c#
using Box.Sdk.Gen;

var ccgConfig = new CcgConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", enterpriseId: "YOUR_ENTERPRISE_ID");
var auth = new BoxCcgAuth(config: ccgConfig);
var client = new BoxClient(auth: auth);
```

#### User Token Acquisition

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2.CCGAuth;
using Box.Sdk.Gen.V2.Config;

var boxConfig = new BoxConfigBuilder(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET")
                .Build();
var boxCCG = new BoxCCGAuth(boxConfig);
var userToken = await boxCCG.UserTokenAsync("YOUR_USER_ID");
var userClient = boxCCG.UserClient(userToken: userToken, userId: "YOUR_USER_ID");
```

**Modern (`Box DotNet SDK`):**

The new SDK streamlines the process:

```c#
using Box.Sdk.Gen;

var ccgConfig = new CcgConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", userId: "YOUR_USER_ID");
var auth = new BoxCcgAuth(config: ccgConfig);
var userClient = new BoxClient(auth: auth);
```

### Smooth Switching between Service Account and User

Transitioning between account types is now more intuitive:

**Modern (`Box DotNet SDK`):**

```c#
using Box.Sdk.Gen;

await auth.AsEnterpriseAsync("ENTERPRISE_ID");
```

### OAuth 2.0 Authentication

OAuth 2.0 remains a robust authentication method. Let's explore the improvements:

#### Fetching the Authorization URL

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2;
using Box.Sdk.Gen.V2.Config;

var config = new BoxConfigBuilder("CLIENT_ID", "CLIENT_SECRET", new System.Uri("YOUR_REDIRECT_URL")).Build();
var client = new BoxClient(config);

// the URL to redirect the user to
var authorizeUrl = "https://account.box.com/api/oauth2/authorize?client_id=[CLIENT_ID]&response_type=code";
```

**Modern (`Box DotNet SDK`):**

The new SDK provides more flexibility:

```c#
using Box.Sdk.Gen;

var config = new OAuthConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET");
var auth = new BoxOAuth(config: config);

// the URL to redirect the user to
var authorizeUrl = auth.GetAuthorizeUrl(new GetAuthorizeUrlOptions() { RedirectUri = "YOUR_REDIRECT_URL" });
```

#### Seamless Authentication

**Legacy (`Box Windows V2 SDK`):**

```c#
using Box.Sdk.Gen.V2;

var session = await client.Auth.AuthenticateAsync("[CODE]");
var client = new BoxClient(config, session);
```

**Modern (`Box DotNet SDK`):**

The new SDK simplifies the process:

```c#
using Box.Sdk.Gen;

await auth.GetTokensAuthorizationCodeGrantAsync("code");
```

### Customizable Token Storage

Token management is crucial for maintaining secure sessions. The new SDK offers enhanced flexibility:

**Legacy (`Box Windows V2 SDK`):**

```c#
// there are no good ways to implement token storage in the legacy sdk
// best that can be done is to respond to the authorization events
public class CustomTokenStorage
{
    // retrieves token
    string RetrieveToken();

    // stores token
    void SaveToken(string accessToken);
}

var client = new BoxClient(config, session);
client.Auth.SessionAuthenticated += delegate (object o, SessionAuthenticatedEventArgs e)
{
    string newAccessToken = e.Session.AccessToken;

    tokenStorage.SaveToken(newAccessToken);
};
```

**Modern (`Box DotNet SDK`):**

The new SDK allows developers to define custom classes for token storage:

```c#
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Task = System.Threading.Tasks.Task;

class CustomTokenStorage : ITokenStorage
{
    // Clear token
    public Task ClearAsync()
    {
        throw new NotImplementedException();
    }

    // Retrieve token
    public Task<AccessToken?> GetAsync()
    {
        throw new NotImplementedException();
    }

    // Store token
    public Task StoreAsync(AccessToken token)
    {
        throw new NotImplementedException();
    }
}

var tokenStorage = new CustomTokenStorage();
var config = new OAuthConfig(clientId: "YOUR_CLIENT_ID", clientSecret: "YOUR_CLIENT_SECRET", tokenStorage: tokenStorage);
```
