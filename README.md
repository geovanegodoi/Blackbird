# Blackbird
ASP.NET Core project based on DDD principles

## Introduction
The layering of an application's codebase is a widely accepted technique to help reduce complexity and to improve code reusability. To achieve a layered architecture, lets follows the principles of Domain Driven Design.

## Domain Driven Design Layers
There are four fundamental layers in Domain Driven Design (DDD):

* **Presentation Layer:** Provides an interface to the user. Uses the Application Layer to achieve user interactions.

* **Application Layer:** Mediates between the Presentation and Domain Layers. Orchestrates business objects to perform specific application tasks.

* **Domain Layer:** Includes business objects and their rules. This is the heart of the application.

* **Infrastructure Layer:** Provides generic technical capabilities that support higher layers mostly using 3rd-party libraries.

![Image of Yaktocat](https://raw.githubusercontent.com/aspnetboilerplate/aspnetboilerplate/master/doc/WebSite/images/abp-nlayer-architecture.png)
