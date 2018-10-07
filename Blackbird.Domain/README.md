# Domain Layer

This is the main layer that implements our domain logic. It includes **Entities**, **Value Objects**, and **Domain Services** to perform business/domain logic. 

It can also include Specifications and trigger Domain Events. 

It defines **Repository Interfaces** to read and persist entities from the data source (generally a DBMS).

## Entities 

One of the core concepts of DDD (**Domain Driven Design**). Eric Evans describe it as "An object that is not fundamentally defined by its attributes, but rather by a thread of continuity and identity".

Essentially, entities have Id's and are stored in a database. An entity is generally mapped to a table in a relational database.

## Value Objects

*"An object that represents a descriptive aspect of the domain with no conceptual identity." (Eric Evans).*

Entities have identities (Id), Value Objects do not. 

If the identities of two Entities are different, they are considered as different objects/entities even if all the properties of those entities are the same. 

Imagine two different people that have the same Name, Surname and Age but are different people (their identity numbers are different). 

For an Address class (which is a classic Value Object), if the two addresses have the same Country, City, and Street number, etc, they are considered to be the same address.

In Domain Driven Design (DDD), the Value Object is another type of domain object which can include business logic and is an essential part of the domain.

## Domain Services (or just Services in DDD) 

Used to perform domain operations and business rules. In his DDD book, Eric Evans describes a good Service in three characteristics:

1. The operation relates to a domain concept that is not a natural part of an Entity or Value Object.
2. The interface is defined in terms of other elements of the domain model.
3. The operation is stateless.

Unlike Application Services which get/return Data Transfer Objects, a Domain Service gets/returns domain objects (like entities or value types).

A Domain Service can be used by Application Services and other Domain Services, but not directly by the presentation layer (application services are for that).
