Refer: https://refactoring.guru/design-patterns/abstract-factory

# Intent

> **Abstract Method** is a creational design pattern that lets you produce families of related
> objects without specifying their concrete classes.

# Problem

> Imagine that you're creating a furniture shop simulator. Your code consists of classes that represent:
> 1. A family of related products, say: **Chair** + **Sofa** + **CoffeeTable**.
>
> 2. Several variants of this family. For example, products **Chair** + **Sofa** + **CoffeeTable**.
>				are available in these variants: **Modern**, **Victorian**, **ArtDeco**.
>
> You need a way to create individual furniture objects so that thay match other objects of the
> same family. Customer get quite mad when they receive non-matching furniture.
>
> Also, you don't want to change existing code when adding new products or families of
> products to the program. Furniture vendors update their catalogs very often, and you 
> wouldn't want to change the core code each time it happens.


# Pros

> * You can be sure that the products you´re getting from a factory are compatible with each other.
> * You avoid tight coupling between concrete products and client code.
> * *Single Responsibility Principle*. You can extract the product creation code into one place, making the code easier to support.
> * *Open/Closed Principle*. You can introduce new variants of produces without breaking existing client code.

# Cons

> * The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.


# Relations with other Patterns

> * Many designs start by using **Factory Method** (Less complicated and more customizable via 
>   subclasses) and evolve toward **Abstract Factory**, **Prototype**, or **Builder**(more flexible, but 
>   more complicated).
>
> * **Builder** focuses on constructing complex objects step by step. **Abstract Factory** specializes
>   in creating families of related objects. *Abstract Factory returns the product immediateky,*
>   whereas *Builder* lets you run some additional construction steps before fetching the product.
> 
> * **Abstract Factory** classes are often based on a set of **Factory Methods**, but you can also 
>   use *Prototype* to compose the methods on these classes.
>
> * You can use **Abstract Factory** along with **Bridge**. This pairing is useful when some
>   abstraction defined by *Bridge* can only work with specific implementations. In this case,
>   *Abstract Factory* can encapsulate these relations and hide the complexity from the client code.
>
> * **Abstract Factories**, **Builders** and **Prototypes** can all  be implemented as **Singletons**.
