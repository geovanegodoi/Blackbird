# Repository Implementations

Used to abstract data access from higher layers. **"Mediates between the domain and data mapping layers using a collection-like interface for accessing domain objects"** (Martin Fowler).

Repositories, in practice, are used to perform database operations for domain objects (Entity and Value types). 

Generally, a separate repository is used for each Entity (or Aggregate Root).

## Best Practices

- **Use default repositories wherever it's possible.** You can use the default repository even if you have a custom repository for an entity (if you use standard repository methods).

- Always create a repository base class for your application for custom repositories, as defined above.

- Define **interfaces for your repositories in the domain layer** (.Core project in startup template), and **repository implementation classes in the persistence layer**, if you want to abstract EF from your domain/application.
