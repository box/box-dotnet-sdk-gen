# IAiManager


- [Send AI question request](#send-ai-question-request)
- [Send AI request to generate text](#send-ai-request-to-generate-text)
- [Get AI agent default configuration](#get-ai-agent-default-configuration)

## Send AI question request

Sends an AI request to supported LLMs and returns an answer specifically focused on the user's question given the provided context.

This operation is performed by calling function `CreateAiAsk`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-ai-ask/).

<!-- sample post_ai_ask -->
```
await client.Ai.CreateAiAskAsync(requestBody: new AiAsk(mode: AiAskModeField.MultipleItemQa, prompt: "Which direction sun rises?", items: Array.AsReadOnly(new [] {new AiAskItemsField(id: fileToAsk1.Id, type: AiAskItemsTypeField.File) { Content = "Earth goes around the sun" },new AiAskItemsField(id: fileToAsk2.Id, type: AiAskItemsTypeField.File) { Content = "Sun rises in the East in the morning" }})));
```

### Arguments

- requestBody `AiAsk`
  - Request body of createAiAsk method
- headers `CreateAiAskHeaders`
  - Headers of createAiAsk method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiResponseFull`.

A successful response including the answer from the LLM.


## Send AI request to generate text

Sends an AI request to supported LLMs and returns an answer specifically focused on the creation of new text.

This operation is performed by calling function `CreateAiTextGen`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-ai-text-gen/).

<!-- sample post_ai_text_gen -->
```
await client.Ai.CreateAiTextGenAsync(requestBody: new AiTextGen(prompt: "Parapharse the document.s", items: Array.AsReadOnly(new [] {new AiTextGenItemsField(id: fileToAsk.Id, type: AiTextGenItemsTypeField.File) { Content = "The Earth goes around the sun. Sun rises in the East in the morning." }})) { DialogueHistory = Array.AsReadOnly(new [] {new AiDialogueHistory() { Prompt = "What does the earth go around?", Answer = "The sun", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") },new AiDialogueHistory() { Prompt = "On Earth, where does the sun rise?", Answer = "East", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") }}) });
```

### Arguments

- requestBody `AiTextGen`
  - Request body of createAiTextGen method
- headers `CreateAiTextGenHeaders`
  - Headers of createAiTextGen method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiResponse`.

A successful response including the answer from the LLM.


## Get AI agent default configuration

Get the AI agent default config

This operation is performed by calling function `GetAiAgentDefaultConfig`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-ai-agent-default/).

<!-- sample get_ai_agent_default -->
```
await client.Ai.GetAiAgentDefaultConfigAsync(queryParams: new GetAiAgentDefaultConfigQueryParams(mode: GetAiAgentDefaultConfigQueryParamsModeField.TextGen) { Language = "en-US" });
```

### Arguments

- queryParams `GetAiAgentDefaultConfigQueryParams`
  - Query parameters of getAiAgentDefaultConfig method
- headers `GetAiAgentDefaultConfigHeaders`
  - Headers of getAiAgentDefaultConfig method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiAgentAskOrAiAgentTextGen`.

A successful response including the default agent configuration.
This response can be one of the following two objects:
AI agent for questions and AI agent for text generation. The response
depends on the agent configuration requested in this endpoint.


