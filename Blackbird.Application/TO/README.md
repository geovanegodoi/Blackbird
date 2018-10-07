# Data Transfer Objects 

Used to transfer data between the Application Layer and the Presentation Layer.

The Presentation Layer calls an Application Service method with a Data Transfer Object (DTO). 

The application service then uses these domain objects to perform some specific business logic, and then finally returns a DTO back to the presentation layer. 

Thus, the Presentation layer is completely isolated from the Domain layer. 

**In an ideally layered application, the presentation layer never works with domain objects, (Repositories, or Entities...).**