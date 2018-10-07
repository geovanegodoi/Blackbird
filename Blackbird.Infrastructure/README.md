# Infrastructure Layer

The infrastructure layer makes other layers work: **It implements the repository interfaces** (using Entity Framework Core for example) to actually work with a real database. 

It may also include an integration to a vendor to send emails and so on. 

This is not a strict layer below all layers, but actually supports other layers by implementing the abstract concepts of them.
