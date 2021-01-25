Refer: https://refactoring.guru/design-patterns/factory-method

# Intent

> <b>Factory Method</b> is a creational design pattern that provides an interface for creating objects in a superclass, 
> but allows subclasses to alter the type of objects that will be created.

# Problem

> Imagine that you're creating a logistics management application. The first version of your app can only handle transportation by trucks,
> so the bulk of you code lives inside the **Truck** class.
>
> After a while, you app becomes pretty popular. Each day you receive dozens of requests from sea transportations companies to incorporate
> sea logistics into the app.
>
> Great news right? But how about the code? At present, most of your code is coupled to the **Truck** class. Adding **Ships** into the app
> would require making changes to the entire codebase. Moreover, if later you decide to add another type transportation to the app, you will 
> probably need to make all these changes again.
>
> As a result, you will end up with nasty code, riddled with conditionals that switch the app's behavior depending on the 
> class of transportation objects.

# Pros

> * You avoid tight coupling between the creator and the concrete products.
> * *Single Responsibility Principle*. You can move the product creation code into one place in the program, making the code easier to support.
> * *Open/Closed Principle*. You can introduce new types of products into the program without breaking existing client code.

# Cons

> * The code may become more complicated since you need to introcduce a lot of new subclasses to implement the pattern. 
>		the best case scenario is when you´re introducing the pattern into an existing hierarchy creator classes.

# Relations with other Patterns

> * Many designs start by using **Factoryt Method** (less complicated and more customizable via
>   subclasses) and evolve toward **Abstract Factory**, **Protortype** or **Builder** (moree flexible, but
>   more complicated).
>
> * **Abstract Factory** classes are often based on a set of **Factory Methods**, but you can also use
>   **Prototype**  to compose the methods on these classes.
>
> * You can use **Factory Method** along with **Iterator** to let collection cubclasses return different 
>   types of interators that are compatible with the collections
>
> * **Prototype** isn't based on inheritance, so it doesn´t have its drawbacks. On the other hand,
>   *Prototype* requires a complicated initialization of the cloned object. **Factory Method** is based
>   on inheritance but doesn't require an initialization step.
>
> * **Factory Method** is a specialization of **Template Method**. At the same time, a *Factory Method*
>   may serve as a step in a large *Template Method*.