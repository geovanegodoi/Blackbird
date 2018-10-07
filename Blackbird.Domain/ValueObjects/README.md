# Value Objects


**"An object that represents a descriptive aspect of the domain with no conceptual identity is called a VALUE OBJECT."** (Eric Evans).

Entities have identities (Id), Value Objects do not. 

If the identities of two Entities are different, they are considered as different objects/entities even if all the properties of those entities are the same. Imagine two different people that have the same Name, Surname and Age but are different people (their identity numbers are different). For an Address class (which is a classic Value Object), if the two addresses have the same Country, City, and Street number, etc, they are considered to be the same address.

In Domain Driven Design (DDD), the Value Object is another type of domain object which can include business logic and is an essential part of the domain.

