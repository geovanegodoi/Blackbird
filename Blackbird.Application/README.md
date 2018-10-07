# Application Layer

The application layer mainly includes **Application Services** that use domain layer and domain objects (Domain Services, Entities...) to perform requested application functionalities. 

It uses Data Transfer Objects to get data from and return data to the presentation or service layer. 

It can also deal with Authorization, Caching, Audit Logging, Object Mapping, the Session and so on...

## Application Services 

Used to expose domain logic to the presentation layer. 

An Application Service is called from the presentation layer using a DTO (Data Transfer Object) as a parameter. 

It also uses domain objects to perform some specific business logic and returns a DTO back to the presentation layer. Thus, the presentation layer is completely isolated from Domain layer.

**In an ideally layered application, the presentation layer never directly works with domain objects.**
