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

# Solution

> The factory Method pattern suggest that you replace direct object construction calls(using the **new** operator) with calls to a special <i>factory</i> method.
> Don't worry: the objects are still created via the **new** operator, but it's being called from within the factory method.
> Objects returned by a factory method are often referred to as **products**.



