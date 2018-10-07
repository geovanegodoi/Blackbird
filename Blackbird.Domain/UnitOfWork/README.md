# Unit Of Work

Connection and transaction management is one of the most important concepts in an application that uses a database. 

You need to know when to open a connection, when to start a transaction, and how to dispose the connection, and so on...

If a unit of work method calls another unit of work method, both use the same connection & transaction. 

The first entered method manages the connection & transaction and then the others reuse it.