# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

## [1.11.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.10.0...v1.11.0) (2025-08-05)


### Bug Fixes

* Fix downscope token to use `retrieveToken` method for token retrieval (box/box-codegen[#731](https://github.com/box/box-dotnet-sdk-gen/issues/731)) ([#492](https://github.com/box/box-dotnet-sdk-gen/issues/492)) ([292360e](https://github.com/box/box-dotnet-sdk-gen/commit/292360efe86797e42dbfb388a5bd2f5b41efa0c1))
* Specify events `next_stream_position` property type as `long` (box/box-openapi[#535](https://github.com/box/box-dotnet-sdk-gen/issues/535)) ([#536](https://github.com/box/box-dotnet-sdk-gen/issues/536)) ([da265bd](https://github.com/box/box-dotnet-sdk-gen/commit/da265bd5c40defc4b2036811aefad59447faca09))


### New Features and Enhancements

* Add `ReadOnlyCollection` implicit operator for Unions (box/box-codegen[#633](https://github.com/box/box-dotnet-sdk-gen/issues/633)) ([#483](https://github.com/box/box-dotnet-sdk-gen/issues/483)) ([a1fc2c5](https://github.com/box/box-dotnet-sdk-gen/commit/a1fc2c584021c151fc9d1815877ffe73c972f711))
* Add AI spreadsheet processor (box/box-openapi[#533](https://github.com/box/box-dotnet-sdk-gen/issues/533)) ([#519](https://github.com/box/box-dotnet-sdk-gen/issues/519)) ([c344023](https://github.com/box/box-dotnet-sdk-gen/commit/c34402355243145a1cab7da78c6c2facde39fb36))
* Add Archive Public API (box/box-openapi[#540](https://github.com/box/box-dotnet-sdk-gen/issues/540)) ([#543](https://github.com/box/box-dotnet-sdk-gen/issues/543)) ([be0bb9d](https://github.com/box/box-dotnet-sdk-gen/commit/be0bb9d3e58f97bc87f749d08d828c990c71789b))
* Add new Hubs APIs and Hubs items API (box/box-openapi[#538](https://github.com/box/box-dotnet-sdk-gen/issues/538)) ([#537](https://github.com/box/box-dotnet-sdk-gen/issues/537)) ([f2584cd](https://github.com/box/box-dotnet-sdk-gen/commit/f2584cd9be40b67eaa3a500411b367543a26f830))
* Add new schema for `Metadata Error` (box/box-openapi[#539](https://github.com/box/box-dotnet-sdk-gen/issues/539)) ([#538](https://github.com/box/box-dotnet-sdk-gen/issues/538)) ([425b4ad](https://github.com/box/box-dotnet-sdk-gen/commit/425b4add7975d49584c8ed18a791caf72559203c))
* add Shield Lists APIs (box/box-openapi[#528](https://github.com/box/box-dotnet-sdk-gen/issues/528)) ([#496](https://github.com/box/box-dotnet-sdk-gen/issues/496)) ([8b81c87](https://github.com/box/box-dotnet-sdk-gen/commit/8b81c879c8b8bb5c020ecb573e527e2a5d9f1701))
* Allow injecting private key decryptor for jwt (box/box-codegen[#754](https://github.com/box/box-dotnet-sdk-gen/issues/754)) ([#528](https://github.com/box/box-dotnet-sdk-gen/issues/528)) ([865c729](https://github.com/box/box-dotnet-sdk-gen/commit/865c729395556a3c4a8bb1f1418c3932d268bdc4))
* make `OneOf` classes public (box/box-codegen[#773](https://github.com/box/box-dotnet-sdk-gen/issues/773)) ([#551](https://github.com/box/box-dotnet-sdk-gen/issues/551)) ([f7dcc32](https://github.com/box/box-dotnet-sdk-gen/commit/f7dcc3262b289da55ebc6210c5656cc98e3b14b4))
* Support Hubs beta endpoints (box/box-openapi[#531](https://github.com/box/box-dotnet-sdk-gen/issues/531)) ([#511](https://github.com/box/box-dotnet-sdk-gen/issues/511)) ([59c43b8](https://github.com/box/box-dotnet-sdk-gen/commit/59c43b868e46edd26be0be13a5e1772a4d731128))
* Support new tools in AI Studio (box/box-openapi[#534](https://github.com/box/box-dotnet-sdk-gen/issues/534)) ([#520](https://github.com/box/box-dotnet-sdk-gen/issues/520)) ([0b47597](https://github.com/box/box-dotnet-sdk-gen/commit/0b47597f259884a2a5f567608e9e07997e3c6dc9))
* Update legal holds and AI models (box/box-openapi[#526](https://github.com/box/box-dotnet-sdk-gen/issues/526)) ([#494](https://github.com/box/box-dotnet-sdk-gen/issues/494)) ([6310e56](https://github.com/box/box-dotnet-sdk-gen/commit/6310e560df6d9520598295139f55ec8a0a4d69d9))
* Use composition instead of inheritance in unions (box/box-codegen[#768](https://github.com/box/box-dotnet-sdk-gen/issues/768)) ([#544](https://github.com/box/box-dotnet-sdk-gen/issues/544)) ([fce6821](https://github.com/box/box-dotnet-sdk-gen/commit/fce68210d16c3eb81dbe907182126f54e2d8610c))

## [1.10.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.9.0...v1.10.0) (2025-05-13)


### New Features and Enhancements

* Add `UploadWithPreflightCheck` convenient method (box/box-codegen[#705](https://github.com/box/box-dotnet-sdk-gen/issues/705)) ([#469](https://github.com/box/box-dotnet-sdk-gen/issues/469)) ([8dff7bb](https://github.com/box/box-dotnet-sdk-gen/commit/8dff7bb859cd034d4e43b81c7c11b9a3fdb396e8))
* Add AI agents warnings; allow for more types of metadata value (box/box-openapi[#520](https://github.com/box/box-dotnet-sdk-gen/issues/520)) ([#474](https://github.com/box/box-dotnet-sdk-gen/issues/474)) ([a53cff5](https://github.com/box/box-dotnet-sdk-gen/commit/a53cff54395db91bad179d3c5bbae9800c1b79dd))
* Add security settings properties on sign template schema (box/box-openapi[#518](https://github.com/box/box-dotnet-sdk-gen/issues/518)) ([#462](https://github.com/box/box-dotnet-sdk-gen/issues/462)) ([7fddaea](https://github.com/box/box-dotnet-sdk-gen/commit/7fddaeab425a859dc1aa5dc3420891047d27efdf))
* Add support of IBM models to AI API (box/box-openapi[#522](https://github.com/box/box-dotnet-sdk-gen/issues/522)) ([#475](https://github.com/box/box-dotnet-sdk-gen/issues/475)) ([a187301](https://github.com/box/box-dotnet-sdk-gen/commit/a187301543d6741c77799b66fde0f12d4fca710d))
* Support sensitive data sanitization in errors (box/box-codegen[#695](https://github.com/box/box-dotnet-sdk-gen/issues/695)) ([#453](https://github.com/box/box-dotnet-sdk-gen/issues/453)) ([5ee0c93](https://github.com/box/box-dotnet-sdk-gen/commit/5ee0c932254a0cd1cc7bc814c29fe5f9e2151462))

## [1.9.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.8.0...v1.9.0) (2025-03-18)


### Bug Fixes

* Add `verification_phone_number` property to create sign request (box/box-openapi[#515](https://github.com/box/box-dotnet-sdk-gen/issues/515)) ([#427](https://github.com/box/box-dotnet-sdk-gen/issues/427)) ([d90faea](https://github.com/box/box-dotnet-sdk-gen/commit/d90faea77650a37ce794a93c51bd9a8eb91f619c))
* Use `targetFramework` when single .Net version is supported (box/box-codegen[#684](https://github.com/box/box-dotnet-sdk-gen/issues/684)) ([#438](https://github.com/box/box-dotnet-sdk-gen/issues/438)) ([4e64174](https://github.com/box/box-dotnet-sdk-gen/commit/4e64174c21c6f1dd2cef75f1f29ebe2ace92d852))


### New Features and Enhancements

* Add find app item for shared link endpoint (box/box-openapi[#514](https://github.com/box/box-dotnet-sdk-gen/issues/514)) ([#426](https://github.com/box/box-dotnet-sdk-gen/issues/426)) ([4dc5dc1](https://github.com/box/box-dotnet-sdk-gen/commit/4dc5dc14e3c204c537180df166d07735ae1c4e40))
* Add Integration Mappings Teams API (box/box-openapi[#517](https://github.com/box/box-dotnet-sdk-gen/issues/517)) ([#429](https://github.com/box/box-dotnet-sdk-gen/issues/429)) ([92063c4](https://github.com/box/box-dotnet-sdk-gen/commit/92063c435d7cb38a7eeca2e71f42e32b995a659a))
* Expose token storage for authentication classes (box/box-codegen[#682](https://github.com/box/box-dotnet-sdk-gen/issues/682)) ([#435](https://github.com/box/box-dotnet-sdk-gen/issues/435)) ([413058e](https://github.com/box/box-dotnet-sdk-gen/commit/413058e78cb69c89be6a819c0e63f9457bd7f2f5))

## [1.8.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.7.0...v1.8.0) (2025-02-20)


### Bug Fixes

* Do not retry HTTP request when `TaskCanceledException` is thrown (box/box-codegen[#665](https://github.com/box/box-dotnet-sdk-gen/issues/665)) ([#406](https://github.com/box/box-dotnet-sdk-gen/issues/406)) ([1af0a6a](https://github.com/box/box-dotnet-sdk-gen/commit/1af0a6aaf5f1e80f092ce506abe1cc01bf110bb8))


### New Features and Enhancements

* Support AI Studio API (box/box-codegen[#626](https://github.com/box/box-dotnet-sdk-gen/issues/626)) ([#409](https://github.com/box/box-dotnet-sdk-gen/issues/409)) ([9661450](https://github.com/box/box-dotnet-sdk-gen/commit/966145021d4a1dd450cd199cc9ed3e9457f5a141))

## [1.7.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.6.0...v1.7.0) (2025-02-06)


### Bug Fixes

* Correct types of `paged` and `thumb` properties in File representation (box/box-openapi[#503](https://github.com/box/box-dotnet-sdk-gen/issues/503)) ([#383](https://github.com/box/box-dotnet-sdk-gen/issues/383)) ([d6995ad](https://github.com/box/box-dotnet-sdk-gen/commit/d6995ad8ffa4f2cceb8195ffbfb6606f934a671f))
* Prevent `Authentication` header from being passed during cross-origin redirects (box/box-codegen[#648](https://github.com/box/box-dotnet-sdk-gen/issues/648)) ([#382](https://github.com/box/box-dotnet-sdk-gen/issues/382)) ([a64d373](https://github.com/box/box-dotnet-sdk-gen/commit/a64d373a935cd2a8e6f72184b8dc129a973e9d45))


### New Features and Enhancements

* Add Box Sign shared requests (box/box-openapi[#504](https://github.com/box/box-dotnet-sdk-gen/issues/504)) ([#384](https://github.com/box/box-dotnet-sdk-gen/issues/384)) ([d563886](https://github.com/box/box-dotnet-sdk-gen/commit/d563886f2a2f48a20df13600f9c25ff95198a56f))
* feat: Add hubs support to /ai/ask. Replace type of `Items` property from `IReadOnlyList<AiItemBase>` to `IReadOnlyList<AiItemAsk>` in the `AiAsk` class (box/box-codegen[#656](https://github.com/box/box-dotnet-sdk-gen/issues/656)) ([#397](https://github.com/box/box-dotnet-sdk-gen/issues/397)) ([32b6d03](https://github.com/box/box-dotnet-sdk-gen/commit/32b6d03aba97c18a8901efe98fc60c74e10197ce))
* Update `/ai/extract_structured` response schema (box/box-codegen[#641](https://github.com/box/box-dotnet-sdk-gen/issues/641)) ([#391](https://github.com/box/box-dotnet-sdk-gen/issues/391)) ([5f79a03](https://github.com/box/box-dotnet-sdk-gen/commit/5f79a03453b9339a26eb130113d8f55748f0d912))

## [1.6.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.5.0...v1.6.0) (2025-01-21)


### Bug Fixes

* Add missing token scope (box/box-openapi[#490](https://github.com/box/box-dotnet-sdk-gen/issues/490)) ([#353](https://github.com/box/box-dotnet-sdk-gen/issues/353)) ([d41e1c8](https://github.com/box/box-dotnet-sdk-gen/commit/d41e1c8c3195a08850f3217fe747e9751a979c76))
* Fix invalid variant config for Integration mapping Slack (box/box-openapi[#492](https://github.com/box/box-dotnet-sdk-gen/issues/492)) ([#356](https://github.com/box/box-dotnet-sdk-gen/issues/356)) ([8320fb7](https://github.com/box/box-dotnet-sdk-gen/commit/8320fb7da8449a8ae9965bd3496523a0f3bfe5af))
* order of fields in the `IntegrationMapping` schema (box/box-openapi[#497](https://github.com/box/box-dotnet-sdk-gen/issues/497)) ([#370](https://github.com/box/box-dotnet-sdk-gen/issues/370)) ([3361ad1](https://github.com/box/box-dotnet-sdk-gen/commit/3361ad1833670f9e99902b2206112592f7272ab8))
* unused parameter from `SignRequest` (box/box-openapi[#489](https://github.com/box/box-dotnet-sdk-gen/issues/489)) ([#343](https://github.com/box/box-dotnet-sdk-gen/issues/343)) ([5d88a51](https://github.com/box/box-dotnet-sdk-gen/commit/5d88a5176489f82057a93bd5dc119e4ae3afdcd7))


### New Features and Enhancements

* Add `aiAgent` info to `AiResponse` (box/box-openapi[#485](https://github.com/box/box-dotnet-sdk-gen/issues/485)) ([#336](https://github.com/box/box-dotnet-sdk-gen/issues/336)) ([cbf91fc](https://github.com/box/box-dotnet-sdk-gen/commit/cbf91fc23012588f0f4175a713d562738818218e))
* Add support for replacing the network client implementation (box/box-codegen[#629](https://github.com/box/box-dotnet-sdk-gen/issues/629)) ([#347](https://github.com/box/box-dotnet-sdk-gen/issues/347)) ([29d904e](https://github.com/box/box-dotnet-sdk-gen/commit/29d904e72fd9c4511183ba35454a82ff9c2d7358))
* Support Box Doc Gen API (box/box-codegen[#644](https://github.com/box/box-dotnet-sdk-gen/issues/644)) ([#378](https://github.com/box/box-dotnet-sdk-gen/issues/378)) ([5cd0fde](https://github.com/box/box-dotnet-sdk-gen/commit/5cd0fdefb6a976fb8904beb08752f3e7dbb7428b))
* Support getting file download URL and file thumbnail URL (box/box-codegen[#642](https://github.com/box/box-dotnet-sdk-gen/issues/642)) ([#374](https://github.com/box/box-dotnet-sdk-gen/issues/374)) ([76b1513](https://github.com/box/box-dotnet-sdk-gen/commit/76b151371f405940eef5ef34fb00809c8f1d8f35))
* Support optional `userId` parameter for updating files, folders and web links (box/box-openapi[#488](https://github.com/box/box-dotnet-sdk-gen/issues/488)) ([#340](https://github.com/box/box-dotnet-sdk-gen/issues/340)) ([fd1c597](https://github.com/box/box-dotnet-sdk-gen/commit/fd1c59739c5361ec4462d2597f504fa3cff5be17))

## [1.5.0](https://github.com/box/box-dotnet-sdk-gen/compare/v1.4.0...v1.5.0) (2024-12-04)


### Bug Fixes

* Support status codes with no content (box/box-codegen[#604](https://github.com/box/box-dotnet-sdk-gen/issues/604)) ([#314](https://github.com/box/box-dotnet-sdk-gen/issues/314)) ([57747d5](https://github.com/box/box-dotnet-sdk-gen/commit/57747d50c48dd4c433dad342a5e2a20ac0b15952))
* update collaboration, metadata and collection resources (box/box-openapi[#483](https://github.com/box/box-dotnet-sdk-gen/issues/483)) ([#316](https://github.com/box/box-dotnet-sdk-gen/issues/316)) ([d331f8a](https://github.com/box/box-dotnet-sdk-gen/commit/d331f8a1f7110e5e00df170cedef85af682d58b4))


### New Features and Enhancements

* Add optional URL parameter to `FetchResponse` (box/box-codegen[#617](https://github.com/box/box-dotnet-sdk-gen/issues/617)) ([#331](https://github.com/box/box-dotnet-sdk-gen/issues/331)) ([61484ec](https://github.com/box/box-dotnet-sdk-gen/commit/61484ec9fbf96c0ae62116ec1ee0cbb50aae7493))
* Allow using default credentials for proxy (box/box-codegen[#623](https://github.com/box/box-dotnet-sdk-gen/issues/623)) ([#334](https://github.com/box/box-dotnet-sdk-gen/issues/334)) ([bc4636e](https://github.com/box/box-dotnet-sdk-gen/commit/bc4636e64859fd7d0b1449ec34b6144d0eb1a768)), closes [#333](https://github.com/box/box-dotnet-sdk-gen/issues/333)
* Expose method for making custom HTTP requests (box/box-codegen[#622](https://github.com/box/box-dotnet-sdk-gen/issues/622)) ([#329](https://github.com/box/box-dotnet-sdk-gen/issues/329)) ([e689140](https://github.com/box/box-dotnet-sdk-gen/commit/e689140d6d3be772ff2370e7de5797707df7bdad))
* Support get collection by ID endpoint (box/box-codegen[#595](https://github.com/box/box-dotnet-sdk-gen/issues/595)) ([#304](https://github.com/box/box-dotnet-sdk-gen/issues/304)) ([9ebf59a](https://github.com/box/box-dotnet-sdk-gen/commit/9ebf59ae388aa9aec5d8a0a3551f13e544c7571d))

## [1.4.0](https://github.com/box/box-codegen/compare/v1.3.1...v1.4.0) (2024-10-31)


### Bug Fixes

* Change `QueryParams` type in `MetadataQuery` from `Dictionary<string, string>` to `Dictionary<string, object>` (box/box-openapi[#479](https://github.com/box/box-codegen/issues/479)) ([#298](https://github.com/box/box-codegen/issues/298)) ([656b495](https://github.com/box/box-codegen/commit/656b495bea779879bb82b2cda0cca5a30a8ad8ca))
* Fix conversion to `RSAKey` (box/box-codegen[#591](https://github.com/box/box-codegen/issues/591)) ([#297](https://github.com/box/box-codegen/issues/297)) ([068b1f7](https://github.com/box/box-codegen/commit/068b1f7b3ea3c62647e03e0e17176bde049949db))


### New Features and Enhancements

* add AI LLM endpoint AWS `params`. Change the type from `AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi` to `AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi` (box/box-openapi[#478](https://github.com/box/box-codegen/issues/478)) ([#291](https://github.com/box/box-codegen/issues/291)) ([dcb8a20](https://github.com/box/box-codegen/commit/dcb8a201577be08b644266c157db45cd6797c71c))

### [1.3.1](https://github.com/box/box-codegen/compare/v1.3.0...v1.3.1) (2024-10-24)


### Bug Fixes

* properly serialize `StringEnum` list when inside query `params` ([#288](https://github.com/box/box-codegen/issues/288)) ([dac8392](https://github.com/box/box-codegen/commit/dac839280b43f4bd954d3966032ff4925150c061))
* update client error schema to support schema errors (box/box-openapi[#467](https://github.com/box/box-codegen/issues/467)) ([#281](https://github.com/box/box-codegen/issues/281)) ([bef2632](https://github.com/box/box-codegen/commit/bef2632af99f0477bd009bcb91248c678b4e1bab))
* update integration mapping response description (box/box-openapi[#463](https://github.com/box/box-codegen/issues/463)) ([#279](https://github.com/box/box-codegen/issues/279)) ([05e07b0](https://github.com/box/box-codegen/commit/05e07b025c234de4c4161e567c0919748d24f804))

## [1.3.0](https://github.com/box/box-codegen/compare/v1.2.0...v1.3.0) (2024-10-17)


### Bug Fixes

* bump `system.text.json` to 8.0.5 (box/box-codegen[#578](https://github.com/box/box-codegen/issues/578)) ([#271](https://github.com/box/box-codegen/issues/271)) ([dad2f52](https://github.com/box/box-codegen/commit/dad2f521066e73c3dcdaec196cd6940401e31f3a))


### New Features and Enhancements

* support proxy (box/box-codegen[#577](https://github.com/box/box-codegen/issues/577)) ([#274](https://github.com/box/box-codegen/issues/274)) ([dea1937](https://github.com/box/box-codegen/commit/dea19373a7169365acb968a66c78c5937ef698e1))

## [1.2.0](https://github.com/box/box-codegen/compare/v1.1.0...v1.2.0) (2024-09-26)


### Bug Fixes

* correctly send `datetime` when in `queryParams` (box/box-codegen[#560](https://github.com/box/box-codegen/issues/560)) ([#243](https://github.com/box/box-codegen/issues/243)) ([9657526](https://github.com/box/box-codegen/commit/9657526667753d77eacfd674cde60ab4030ae42d))
* Fix variants in metadata query results (box/box-openapi[#456](https://github.com/box/box-codegen/issues/456)) ([#249](https://github.com/box/box-codegen/issues/249)) ([37625ea](https://github.com/box/box-codegen/commit/37625eabe4f87d57a9f58920829c00cddd34bcb1))


### New Features and Enhancements

* add Hubs Beta (box/box-openapi[#453](https://github.com/box/box-codegen/issues/453)) ([#241](https://github.com/box/box-codegen/issues/241)) ([c28f660](https://github.com/box/box-codegen/commit/c28f6605c94e250bbab853ef610c46c1d3c9ef95))
* include raw `json` in types (box/box-codegen[#567](https://github.com/box/box-codegen/issues/567)) ([#258](https://github.com/box/box-codegen/issues/258)) ([a1e7bc5](https://github.com/box/box-codegen/commit/a1e7bc55da0dec8bfd1159a1c158154177581019))
* Support `ai/extract` and `ai/extract_structured` endpoints (box/box-codegen[#564](https://github.com/box/box-codegen/issues/564)) ([#253](https://github.com/box/box-codegen/issues/253)) ([a17d8f8](https://github.com/box/box-codegen/commit/a17d8f8dbce8ac7f42b9e23c8c216e992a64d762))

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
