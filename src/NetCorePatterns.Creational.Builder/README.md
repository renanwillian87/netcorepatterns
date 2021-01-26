Refer: https://refactoring.guru/design-patterns/builder

# Intent

> **Builder** is a creational design pattern that lets you construct complex objects step by step. The
> pattern allows you to produce different types and representations of an object using the same
> construction code.

# Problem

> Imagine a complex object that requires laborious, step-by-step initialization of many fields and
> nested objects. Such initialization code is usually burried inside a monstrous contructor with
> lots of parameters. Or even worse: scattered all over the client code.
> 
> For example, let's think about how to create a **House** object. To build a simple house, you
> need to construct four walls and a floor, install a door, fit a pair of windows, and build a roof.
> But what if you want a bigger, brighter house, with a backyard and other goodies (like a
> heating system, plumbing, and electrical wiring)?
> 
> The simplest solution is to extend the base **House** class and create a set of subclasses to
> cover all combinations of the parameters. But eventually you'll end up with a considerable
> number of subclasses. Any new parameter, such as the porch style, will require growing this
> hierarchy even more.
> 
> There's another approach that doesn't involve breeding subclasses. You can create a giant
> constructor right in the base **House** class with all possible parameters that control the house
> object. While this approach indeed eliminates the need for subclasses, it creates another
> problem.
> 
> In  most cases of the parameters will be unused, makiung **the constructor calls pretty ugly**.
> For instance, only fraction of houses have swimming pools, so the parameters related to
> swimming pools will be useless nine time out of ten.

# Pros

> You can construct objects step-by-step, defer construction steps or run steps recursively.
> You can reuse the same construction code when building various representations of products.
> *Single Responsibility Principle*. You can isolate complex construction code from the business logic of the product.

# Cons

> The overall complexity of the code increases since the pattern requires creating multiple new classes.

# Relations with other Patterns

> * Many designs start by using **Factory Method** (less complicated and more customizable via 
>   subclasses) and evolve toward **Abstract Factory**, **Prototype**, or **Builder** (more flexible, but
>   more complicated).
>  
> * **Builder** focuses on constructing complex objects step by step. **Abstract Factory** specilizes
>   in creating families of related objects. *Abstract Factory* returns the product immediately,
>   whereas *Builder* lets you run some additional construction steps before fetching the
>   product.
> 
> * You can use **Builder** when creating complex **Composite** trees because you can program its
>   construction steps to work recursively.
> 
> * You can combine **Builder** with **Bridge**: the director class plays the role of the abstraction
>   while different builders act as implementations.
> 
> * **Abstract Factories**, **Builders** and **Prototypes** can all be implemented as **Singletons**.