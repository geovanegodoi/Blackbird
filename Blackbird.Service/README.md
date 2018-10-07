# Service Layer

This layer is used to serve application/domain functionality via remote APIs like REST, OData, GraphQL... 

They don't contain business logic but only translate HTTP requests to domain interactions, or can use application services to delegate the operation. 

This layer generally includes Authorization, Caching, Audit Logging, Object Mapping, Exception Handling, Session and so on...
