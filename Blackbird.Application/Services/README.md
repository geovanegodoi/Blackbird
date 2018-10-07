# Application Services 

Used to expose domain logic to the presentation layer. 

An Application Service is called from the presentation layer using a DTO (Data Transfer Object) as a parameter. 

It also uses domain objects to perform some specific business logic and returns a DTO back to the presentation layer. Thus, the presentation layer is completely isolated from Domain layer.

**In an ideally layered application, the presentation layer never directly works with domain objects.**