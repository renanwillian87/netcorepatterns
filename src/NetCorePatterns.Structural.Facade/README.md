Refer: https://refactoring.guru/design-patterns/facade

# Intent

> **Facade** is a structural design pattern that provides a simplified interface to a library, a 
> framework, or any other complex set of classes.

# Problem

> Imagine that you must make your code work with a broad set of objects that belong to a
> sophisticated library or framework. Ordinarily, you'd need to initialize all of those objects, keep
> track of dependencies, execute methods in correct order, and so on.
> 
> As a result, the business logic of your classes would become tightly coupled to the
> implementation details of 3rd-party clases, making it hard to comprehend and maintain.

# Pros

> * You can isolate your code from the complexity of a subsystem.

# Cons

> A facade can become **a god object** coupled to all classes of an app.

# Relations with other Patterns

> * **Facade** defines a new interface for existing objects, whereas **Adapter** tries to make the
>   existing interface usable. *Adapter* usually wraps just one object, while *Facade* works with an 
>   entire subsystem of objects
>  
> * **Abstract Factory** can serve as an alternative to **Facade** when you only want to hide the way 
>   the subsystem objects are created from the client code.
> 
> * **Flyweight** shows how to make a lots of little objects, whereas **Facade** shows how to make a
>   single object that represents an entire subsystem.
> 
> * **Facade** and **Mediator** have similar jobs: they try to organize collaboration between lots of
>   tightly coupled classes.
>   + *Facade* defines a simplified interface to a subsystem of objects, but it doesn't introduce
>		  any new functionality. The subsystem itself is unaware of the facade. Objects within the
>     subsystem can communicate directly.
>   + *Mediator* centralizes communication between components of the system. The
>     components only know about the mediator object and don't communicate directly.
>
> * A **Facade** class can often be transformed into **Singleton** since facade object is
>   sufficient in most cases.
>
> * **Facade** is similar to **Proxy** in that both buffer a complex entity and initialize it on its own.
>   Unlike *Facade*, *Proxy* has the same interface as its service object, which makes them 
>   interchangeable.
