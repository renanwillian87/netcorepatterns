Refer: https://refactoring.guru/design-patterns/proxy

# Intent

> **Proxy** is a structural design pattern that lets you provide a substitute or placeholder for
> another object. A proxy controls access to the original object, allowing you to perform
> something either before or after the request gets through to the original object.

# Proxy in C#

> **Proxy** is a structural design pattern that provides an object that acts as substitute
> from a real service object used by a client. A proxy receives client requests, does some work
> (acces control, caching, etc.) and then passes the request to a service object.

> 
# Problem

> Why would you want to control access to an object? Here is an exemple: you have a massive  
> object that consumes a vast amount of system resources. You need it from to time, but
> not always.
> 
> You could implement lazy initialization: create this object only when it's actually needed. All of
> the objects's clients would need to execute some deferred initialization code. Unfortunately,
> this would probably cause a lot of code duplication.
> 
> In an ideal world, we'd want to put this code directly into our object's class, but that isn't
> always possible. For instance the class may be part of a closed 3rd-party library.

# Solution 

> The proxy pattern suggests that you create a new proxy class with the same interface as an
> original service object. Then you update your app so that it passes the proxy object to all of
> the original object's clients. Upon receiving a request from a client, the proxy creates a real
> service object and delegates all the work to it.
> 
> But what's the benefit? if you need to execute something either before or after the primary
> logic of the class, the proxy lets you do this without changing that class. Since the proxy
> implements the same interface as the original class, it can be passed to any client that expects
> a real service object.

# Pros

> * You can control the service object without clients knowing about it.
> * You can manage the lifecycle of the service object when clients don't care about it.
> * The proxy works even if the service object isn't ready or is not available.
> * *Open/Closed Principle*. You can introduce new proxies without changing the server or clients.

# Cons

> * The code may become more complicated since you need to introduce a lot of new classes.
> * The response from the service might get delayed.

# Relations with other Patterns

> * **Adapter** provides a different interface to the wrapped object, **Proxy** provides it with the
>   same interface, and **Decorator** provides it with an enhanced interface.
> 
> * **Facade** is similar to **Proxy** in that both buffer a complex, entity and initialize it on its own.
>   Unlike *Facade*, *Proxy* has the same interface as its service object, which makes them interchangeable.
> 
> * **Decorator** and **Proxy** have similar structures, but very different intents. Both patterns are
>   built on the composition priciple, where one object is suposed to delegate some of the
>   work to another. The difference is that a *Proxy* usually manages the lifecycle of its service
>   object on its own, whereas the composition of *Decorators*is always controlled by the client.