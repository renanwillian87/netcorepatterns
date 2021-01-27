Refer: https://refactoring.guru/design-patterns/bridge

# Intent

> **Bridge** is a structural design pattern that lets you split a large class or a set of closely related
> classes into two separate hierarchies-abstraction and implementation-which can be
> developed independently of each other.

# Problem

> *Abstraction?* *Implementation?* *Sound scary?* Stay calm and let's consider a simple example.
> 
> Say you have a geometric **Shape** class with a pair of subjects: **Circle** and **Square**. You
> want to extend this class hierarchy to incorporate colors, so you plan to create **Red** and 
> **Blue** Shape subclasses. However, since you already have two subclasses, you'll need to create
> four class combinations such as **BlueCircle** and **RedSquare**
> 
> Adding new shape types to the hierarchy will grow it exponentially. For example, to
> add a triangle shape you'd need to introduce two subclasses, one for each color. And after that,
> adding a new color would require creating three subclasses, one for each shape type. The
> further we go, the worse it becomes.

# Pros

> * You can create platform-independent classes and apps.
> * The client code works with high-level abstractions. It isn't exposed to the platform details.
> * *Open/Closed Principle*. You can introduce new abstraction and on platform details in the implementation.

# Cons

> * You might make the code more complicated by applying the pattern to a highly cohesive class.
> 

# Relations with other Patterns

> * **Bridge** is usually designed up-front, letting you develop parts of an application independently of each other. On
>   the other hand, **Adapter** is commonly used with an existing app to make some otherwise-incompatible classes
>   work together nicely.
> 
> * **Bridge**, **State**, **Strategy** (and to some degree **Adapter**) have very similar structure. Indeed, all of these patterns
>   are based on composition, which is delegating work to other objects. However, they all solve different problems.
>   A pattern isn't just a recipe for structuring your code in a specific way. It can also communicate to other
>   developers the problem the pattern solves.
>
> * You can use **Abstract Factory** along with **Bridge**. This pairing is useful when some abstractions defined by *Bridge*
>   can only work with specific implementations. In this case, *Abstract Factory* can encapsulate these relations and
>   hide the complexity from the client code
>
> * You can combine **Builder** with **Bridge**: the director class plays the role of the abstraction, while different builders
>   act as implementations
>