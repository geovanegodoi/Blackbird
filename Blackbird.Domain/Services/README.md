# Domain Services

Used to perform domain operations and business rules. In his DDD book, Eric Evans describes a good Service in three characteristics:

1. The operation relates to a domain concept that is not a natural part of an Entity or Value Object.

2. The interface is defined in terms of other elements of the domain model.

3. The operation is stateless.

Unlike Application Services which get/return Data Transfer Objects, a Domain Service gets/returns domain objects (like entities or value types).

A Domain Service can be used by Application Services and other Domain Services, but not directly by the presentation layer (application services are for that).