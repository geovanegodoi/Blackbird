# Domain Events

Domain events can be used to decouple business logic and to react to important domain changes in an application.

The EventBus is a singleton object that is shared by other classes to trigger and handle events. 

This is useful for a desktop application or standalone windows service, but for a web application it's a bit problematic since objects are created in a web request and are short-lived. 

It's hard to register some class events. Directly registering to another class's event makes classes tightly coupled.