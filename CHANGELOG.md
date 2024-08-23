# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

## [1.1.0](https://github.com/box/box-codegen/compare/v1.0.0...v1.1.0) (2024-08-23)


### Bug Fixes

* Add missing `item_upload` scope ([#201](https://github.com/box/box-codegen/issues/201)) ([483b055](https://github.com/box/box-codegen/commit/483b05586f8e45771e101d286fddebc564ff89bd))
* Add missing fields to Sign Template Signer and fix AI schema (box/box-openapi[#451](https://github.com/box/box-codegen/issues/451)) ([#229](https://github.com/box/box-codegen/issues/229)) ([121f733](https://github.com/box/box-codegen/commit/121f733f52e945927125f4941206b1553202914d))
* Fix `IntegrationMapping` schemas (box/box-codegen[#551](https://github.com/box/box-codegen/issues/551)) ([#226](https://github.com/box/box-codegen/issues/226)) ([3eca154](https://github.com/box/box-codegen/commit/3eca15434b65bc0bb2421d36ec50691e7fe40e3b))
* Improve handling of network exceptions, handle big file upload (box/box-openapi[#444](https://github.com/box/box-codegen/issues/444)) ([#222](https://github.com/box/box-codegen/issues/222)) ([75ccd07](https://github.com/box/box-codegen/commit/75ccd078e29015b865462ea1aaf0420d5e63d9cd))


### New Features and Enhancements

* add new parameters to Box AI methods and introduce `AiResponseFull` variant (box/box-openapi[#446](https://github.com/box/box-codegen/issues/446)) ([#224](https://github.com/box/box-codegen/issues/224)) ([6d205c4](https://github.com/box/box-codegen/commit/6d205c4e28a657ad65ae704a7343a8670806f7f1))
* Include URL into `FetchOptions` (box/box-codegen[#549](https://github.com/box/box-codegen/issues/549)) ([#231](https://github.com/box/box-codegen/issues/231)) ([41c45dc](https://github.com/box/box-codegen/commit/41c45dcf6476b6cae7941c0952c375aa76ce42a1))
* parametrise chunked uploads endpoint urls (box/box-openapi[#444](https://github.com/box/box-codegen/issues/444)) ([#208](https://github.com/box/box-codegen/issues/208)) ([feac37c](https://github.com/box/box-codegen/commit/feac37c34f99b5951731b605ef895f7f3b5de6dd))
* Support `nullable` fields (box/box-codegen[#550](https://github.com/box/box-codegen/issues/550)) ([#230](https://github.com/box/box-codegen/issues/230)) ([b9da32b](https://github.com/box/box-codegen/commit/b9da32b27f506618faa0119f725528555be14f60))

## [1.0.0](https://github.com/box/box-codegen/compare/v0.4.0...v1.0.0) (2024-07-24)


### Bug Fixes

* Extract `IntegrationMappingPartnerItemSlack` to `IntegrationMappingPartnerItemSlackUnion` (box/box-codegen[#530](https://github.com/box/box-codegen/issues/530)) ([#183](https://github.com/box/box-codegen/issues/183)) ([3b1b634](https://github.com/box/box-codegen/commit/3b1b634904edc73af094aa8aa6e89d32b9e92aee))
* Improve chunked upload reliability (box/box-codegen[#529](https://github.com/box/box-codegen/issues/529)) ([#182](https://github.com/box/box-codegen/issues/182)) ([e2a045f](https://github.com/box/box-codegen/commit/e2a045f5d2afbe15be0284099ee2236f9c19cd73))
* remove `init` from some of the required fields, `nullability` fixes (box/box-codegen[#532](https://github.com/box/box-codegen/issues/532)) ([#190](https://github.com/box/box-codegen/issues/190)) ([c58f8af](https://github.com/box/box-codegen/commit/c58f8afa41fa4346eb3f2ced9e48695980e917e1))
* retry requests with status code of 202 and `retry-after` header (box/box-codegen[#533](https://github.com/box/box-codegen/issues/533)) ([#191](https://github.com/box/box-codegen/issues/191)) ([abaafd7](https://github.com/box/box-codegen/commit/abaafd70b982ae560430ff083b4bee1d533d5275))
* Update chunked upload (box/box-codegen[#523](https://github.com/box/box-codegen/issues/523)) ([#177](https://github.com/box/box-codegen/issues/177)) ([9bcaf51](https://github.com/box/box-codegen/commit/9bcaf51e0bcd3134dea2b37277a24abaa483754a))


### New Features and Enhancements

* Add `is_active` parameter to user collaboration (box/box-openapi[#437](https://github.com/box/box-codegen/issues/437)) ([#181](https://github.com/box/box-codegen/issues/181)) ([ec5f2d1](https://github.com/box/box-codegen/commit/ec5f2d1d2cdba330f26a7db40042b70d3ec5bca2))
* simplify `namespaces` (box/box-codegen[#518](https://github.com/box/box-codegen/issues/518)) ([#175](https://github.com/box/box-codegen/issues/175)) ([7831b09](https://github.com/box/box-codegen/commit/7831b098971616497cbc90a8c277fee9b2c42c39))
* Support AI Agent API (box/box-codegen[#531](https://github.com/box/box-codegen/issues/531)) ([#188](https://github.com/box/box-codegen/issues/188)) ([0c29645](https://github.com/box/box-codegen/commit/0c296458ef966e57c5aba2a8068034d4de820ef9))
* Support default interface properties, bump dependencies (box/box-codegen[#527](https://github.com/box/box-codegen/issues/527)) ([#184](https://github.com/box/box-codegen/issues/184)) ([6b52792](https://github.com/box/box-codegen/commit/6b52792057ab94f6bcc2f86b47e0ed5f25900adf))

## [0.4.0](https://github.com/box/box-codegen/compare/v0.3.1...v0.4.0) (2024-07-03)


### Bug Fixes

* Change base urls (box/box-codegen[#491](https://github.com/box/box-codegen/issues/491)) ([#126](https://github.com/box/box-codegen/issues/126)) ([b4c6025](https://github.com/box/box-codegen/commit/b4c6025dc7039e923b19282333f162bb9d3469a9))
* Fix CI for auto update pull requests (box/box-codegen[#506](https://github.com/box/box-codegen/issues/506)) ([#152](https://github.com/box/box-codegen/issues/152)) ([766f03c](https://github.com/box/box-codegen/commit/766f03c743b7a2ab363135ff282e468b6b71d377))
* Fix schemas for updating classification on a file and folder (box/box-openapi[#423](https://github.com/box/box-codegen/issues/423)) ([#117](https://github.com/box/box-codegen/issues/117)) ([40f5a97](https://github.com/box/box-codegen/commit/40f5a97ea44118ff9425e8b0ebb767d9ed08cee7))
* Improve wording for box sign (box/box-openapi[#424](https://github.com/box/box-codegen/issues/424)) ([#122](https://github.com/box/box-codegen/issues/122)) ([64b3bcd](https://github.com/box/box-codegen/commit/64b3bcd2d99039d1c881a565de6e7bc40dfe7aa9))


### New Features and Enhancements

* Add default implementation for interface methods (box/box-codegen[#502](https://github.com/box/box-codegen/issues/502)) ([#148](https://github.com/box/box-codegen/issues/148)) ([0f39071](https://github.com/box/box-codegen/commit/0f39071d2442b9d07f9c51de8a5a757b16cc4fe7))
* Add docs improvements and marker pagination (box/box-openapi[#431](https://github.com/box/box-codegen/issues/431)) ([#153](https://github.com/box/box-codegen/issues/153)) ([780a58b](https://github.com/box/box-codegen/commit/780a58b4d4b18c357381c76dd5e72dd791a20d89))
* Add support for `ExtraData` of generic type `(box/box-codegen[#521](https://github.com/box/box-codegen/issues/521))` ([#170](https://github.com/box/box-codegen/issues/170)) ([2a2208d](https://github.com/box/box-codegen/commit/2a2208d422f5beb1718576acdc10d9eb973ba95c))
* Add support for unions of primitives (box/box-codegen[#501](https://github.com/box/box-codegen/issues/501)) ([#150](https://github.com/box/box-codegen/issues/150)) ([e75ce82](https://github.com/box/box-codegen/commit/e75ce82b09641d4bec439d620facbbf25da97845))
* Make models immutable, hide fields for auths (box/box-codegen[#494](https://github.com/box/box-codegen/issues/494)) ([#127](https://github.com/box/box-codegen/issues/127)) ([8adcc85](https://github.com/box/box-codegen/commit/8adcc858ef0f924f168406b031d379c786fa90d0))
* Add `SuppressNotifications` and `ExternalSystemName` fields for Box Sign (box/box-openapi[#425](https://github.com/box/box-codegen/issues/425)) ([#124](https://github.com/box/box-codegen/issues/124)) ([c841881](https://github.com/box/box-codegen/commit/c841881cea9b0636bb624fe45d77c2817327dd35))
* Support `StringEnum` (box/box-codegen[#514](https://github.com/box/box-codegen/issues/514)) ([#162](https://github.com/box/box-codegen/issues/162)) ([6ac2fe9](https://github.com/box/box-codegen/commit/6ac2fe9811efde6b02cd3ca50834b0bdafea1ab3))

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
