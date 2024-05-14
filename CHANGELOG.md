# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

### [0.3.1](https://github.com/box/box-codegen/compare/v0.3.0...v0.3.1) (2024-05-14)


### Bug Fixes

* **docs:** fixes for chunked uploads docs (box/box-codegen[#457](https://github.com/box/box-codegen/issues/457)) ([#64](https://github.com/box/box-codegen/issues/64)) ([744fd8b](https://github.com/box/box-codegen/commit/744fd8b9586a7985eb7ff06d7a1379857da9886c))
* fix `datetimeToString` utils function (box/box-codegen[#459](https://github.com/box/box-codegen/issues/459)) ([#57](https://github.com/box/box-codegen/issues/57)) ([96745b6](https://github.com/box/box-codegen/commit/96745b64b75ded429a3ae5709ea826ffddede406))
* Fix Box AI endpoints (box/box-openapi[#418](https://github.com/box/box-codegen/issues/418)) ([#92](https://github.com/box/box-codegen/issues/92)) ([450a46d](https://github.com/box/box-codegen/commit/450a46d5e76df86d1f23a246094cf098dfafb689))
* fix docs code samples (box/box-codegen[#451](https://github.com/box/box-codegen/issues/451)) ([#53](https://github.com/box/box-codegen/issues/53)) ([5f79cfd](https://github.com/box/box-codegen/commit/5f79cfd07c8b922961c3db56d64dc142aec1191c))
* Fix metadata filter resource (box/box-openapi[#419](https://github.com/box/box-codegen/issues/419)) ([#94](https://github.com/box/box-codegen/issues/94)) ([8c119e7](https://github.com/box/box-codegen/commit/8c119e75719ea8557437f7a71d2c22409ae93cad))
* fix queryParams when they contain a json array (box/box-codegen[#470](https://github.com/box/box-codegen/issues/470)) ([#67](https://github.com/box/box-codegen/issues/67)) ([9e860cf](https://github.com/box/box-codegen/commit/9e860cf977e677f34350aa09249b1752f2c5004e))
* remove mixed union case serialization in c# (box/box-codegen[#485](https://github.com/box/box-codegen/issues/485)) ([#96](https://github.com/box/box-codegen/issues/96)) ([4b44940](https://github.com/box/box-codegen/commit/4b4494085e1977ddd563c316f8fe7feca9ccb425))


### New Features and Enhancements

* Assign default value to fields and args of type enum with only one value (box/box-codegen[#465](https://github.com/box/box-codegen/issues/465)) ([#66](https://github.com/box/box-codegen/issues/66)) ([be7a2b2](https://github.com/box/box-codegen/commit/be7a2b261610564bccc1ffdd59116fc37390ae2b))
* Change `asUser` and `asEnterprise` method names (box/box-codegen[#464](https://github.com/box/box-codegen/issues/464)) ([#61](https://github.com/box/box-codegen/issues/61)) ([f654666](https://github.com/box/box-codegen/commit/f65466661c1f4b73e43025d8f2f7c1b843fea252))
* Move schemas to separate modules (box/box-codegen[#483](https://github.com/box/box-codegen/issues/483)) ([#104](https://github.com/box/box-codegen/issues/104)) ([1c58465](https://github.com/box/box-codegen/commit/1c58465bf9405cda1aebce9f36d800022c09635c))
* Support Box AI endpoints (box/box-openapi[#416](https://github.com/box/box-codegen/issues/416)) ([#90](https://github.com/box/box-codegen/issues/90)) ([7664392](https://github.com/box/box-codegen/commit/7664392651e0338098bc1d1b1bc1f79477f158f3))
* support excluding endpoints and schemas in parser (box/box-codegen[#487](https://github.com/box/box-codegen/issues/487)) ([#105](https://github.com/box/box-codegen/issues/105)) ([d6aedf8](https://github.com/box/box-codegen/commit/d6aedf801890d96bf2e9da0b797136f771076ecc))
* support revoking and downscoping token for BoxDeveloperTokenAuth ([#74](https://github.com/box/box-codegen/issues/74)) ([adb7e04](https://github.com/box/box-codegen/commit/adb7e0491dab3cb527fe5992964cf190b51f1900))
* Update `outcomes` parameter of `StartWorkflow` (box/box-openapi[#413](https://github.com/box/box-codegen/issues/413)) ([#50](https://github.com/box/box-codegen/issues/50)) ([02c7c2b](https://github.com/box/box-codegen/commit/02c7c2b74b70d92be372b57c7b7b4473b98d76d0))
* use getDiscriminatorForUnion in C# (box/box-codegen[#462](https://github.com/box/box-codegen/issues/462)) ([#62](https://github.com/box/box-codegen/issues/62)) ([c6846d8](https://github.com/box/box-codegen/commit/c6846d8334fdb06da22f99baf416007230c69252))

### [0.3.0](https://github.com/box/box-dotnet-sdk-gen/compare/v0.2.0...v0.3.0) (2024-03-13)


### New Features and Enhancements

* add  method to authentication classes (box/box-codegen[#442](https://github.com/box/box-dotnet-sdk-gen/issues/442)) ([5560f23](https://github.com/box/box-dotnet-sdk-gen/commit/5560f2334d50e568d20a5b83bd7e99510ff97ca5))
* add `retrieveAuthorizationHeader` method to authentication classes (box/box-codegen[#442](https://github.com/box/box-dotnet-sdk-gen/issues/442)) ([480a710](https://github.com/box/box-dotnet-sdk-gen/commit/480a710f8fd713bc9355d85ac8919d4ad988dc92))
* add local to Function, Field and Type to mark as private for Python (box/box-codegen[#440](https://github.com/box/box-dotnet-sdk-gen/issues/440)) ([6c699c7](https://github.com/box/box-dotnet-sdk-gen/commit/6c699c7e17b6232b4900d37aa0e73059450ac1c3))
* Support version in request headers (box/box-codegen[#418](https://github.com/box/box-dotnet-sdk-gen/issues/418)) ([#34](https://github.com/box/box-dotnet-sdk-gen/issues/34)) ([cdc5806](https://github.com/box/box-dotnet-sdk-gen/commit/cdc5806fba30cf07e4f17e02e106b55c0a7c6a1d))
* throw BoxApiError in C# fetch, add additional data to ResponseInfo (box/box-codegen[#439](https://github.com/box/box-dotnet-sdk-gen/issues/439)) ([#23](https://github.com/box/box-dotnet-sdk-gen/issues/23)) ([6dce6d7](https://github.com/box/box-dotnet-sdk-gen/commit/6dce6d7eb28aa7936db1fecdedeff24eadded2c7))
