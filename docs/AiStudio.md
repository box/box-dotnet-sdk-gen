# IAiStudioManager


- [List AI agents](#list-ai-agents)
- [Create AI agent](#create-ai-agent)
- [Update AI agent](#update-ai-agent)
- [Get AI agent by agent ID](#get-ai-agent-by-agent-id)
- [Delete AI agent](#delete-ai-agent)

## List AI agents

Lists AI agents based on the provided parameters.

This operation is performed by calling function `GetAiAgents`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-ai-agents/).

*Currently we don't have an example for calling `GetAiAgents` in integration tests*

### Arguments

- queryParams `GetAiAgentsQueryParams`
  - Query parameters of getAiAgents method
- headers `GetAiAgentsHeaders`
  - Headers of getAiAgents method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiMultipleAgentResponse`.

A successful response including the agents list.


## Create AI agent

Creates an AI agent. At least one of the following capabilities must be provided: `ask`, `text_gen`, `extract`.

This operation is performed by calling function `CreateAiAgent`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-ai-agents/).

*Currently we don't have an example for calling `CreateAiAgent` in integration tests*

### Arguments

- requestBody `CreateAiAgentAsync`
  - Request body of createAiAgent method
- headers `CreateAiAgentHeaders`
  - Headers of createAiAgent method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiSingleAgentResponseFull`.

Definition of created AI agent.


## Update AI agent

Updates an AI agent.

This operation is performed by calling function `UpdateAiAgentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-ai-agents-id/).

*Currently we don't have an example for calling `UpdateAiAgentById` in integration tests*

### Arguments

- agentId `string`
  - The ID of the agent to update. Example: "1234"
- requestBody `CreateAiAgentAsync`
  - Request body of updateAiAgentById method
- headers `UpdateAiAgentByIdHeaders`
  - Headers of updateAiAgentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiSingleAgentResponseFull`.

Definition of created AI agent.


## Get AI agent by agent ID

Gets an AI Agent using the `agent_id` parameter.

This operation is performed by calling function `GetAiAgentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-ai-agents-id/).

*Currently we don't have an example for calling `GetAiAgentById` in integration tests*

### Arguments

- agentId `string`
  - The agent id to get. Example: "1234"
- queryParams `GetAiAgentByIdQueryParams`
  - Query parameters of getAiAgentById method
- headers `GetAiAgentByIdHeaders`
  - Headers of getAiAgentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AiSingleAgentResponseFull`.

A successful response including the agent.


## Delete AI agent

Deletes an AI agent using the provided parameters.

This operation is performed by calling function `DeleteAiAgentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-ai-agents-id/).

*Currently we don't have an example for calling `DeleteAiAgentById` in integration tests*

### Arguments

- agentId `string`
  - The ID of the agent to delete. Example: "1234"
- headers `DeleteAiAgentByIdHeaders`
  - Headers of deleteAiAgentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

A successful response with no content.


