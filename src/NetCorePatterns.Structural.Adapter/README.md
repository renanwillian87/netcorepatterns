Refer: https://refactoring.guru/design-patterns/adapter

# Intent

> **Adapter** is a structural design pattern that allows objects with incompatible interfaces
> to collaborate

# Problem

> Imagine that you're creating a stock market monitoring app. The app downloads the stock data
> from multiple sources in XML format and then displays nice-looking charts and diagrams for
> the user.
> 
> At some point, you decide to improve the app by integrating a smart 3rd-party analytics
> library. But there's a catch: the analytics library only works with data in JSON format.
> 
> You could change the library to work with XML. However, this might break some existing code
> that relies on the library. And worse, you might not have acces to the library's source code in
> the first place, making this approach impossible.

# Pros

> * *Single Responsibility Principle*. You can separate the interface or data conversion code from 
>   the primary business logic of the program
> * *Open/Closed Principle*. You can introduce new types of adapters into the program without breaking the 
>   existing client code, as long as they work with the adapter through the client interface.

# Cons

> * The overall complexity of the code increases because you need to introduce a set of new interfaces and classes.
>   Sometimes it's simpler just to change the service class so that it matches the rest of your code.

# Relations with other Patterns

> * **Bridge** is usually designed up-front, letting you develop parts of an application
>   independently of each other. On the other hand, **Adapter** is commonly used with an 
>   existing app to make some otherwise-incompatible classes work together nicely.
>  
> * **Adapter** changes the interface of an existing object, while **Decorator** enhances an object
>   without changing its interface. In addition, *Decorator* supports recursive composition, wich
>   isn't possible when you use *Adapter*.
>
> * **Adapter** provides a different interface to the wrapped object, **Proxy** provides it with the
>   same interface, and **Decorator** provides it with an enhanced interface.
>
> * **Facade** defines a new interface for existing objects, whereas **Adapter** tries to make the
>   existing interface usable. *Adapter* usually wraps just one object, while *Facade* works with an
>   entire subsystem of objects.
>
> * **Bridge**, **State**, **Strategy** (and to some degree **Adapter**) have very similar structures. Indeed,
>   all of these patterns are based on composition, which is delegating work to other objects.
>   However, they all solve different problems. A pattern isn't just a recipe for structuring your
>   code in specific way. It also communicate to other developers the problem the pattern
>   solves.