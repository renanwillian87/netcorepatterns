Refer: https://refactoring.guru/design-patterns/proxy

# Also know as
> Event-Subscriber, Listener

# Intent

> **Observer** is a behavioral design pattern that lets you define a subscription mechanism to notify
> multiple objects about any avents that happen to the object they're observing.
> 

# Observer in C#

> **Observer** is a behavioral design pattern that allows some objects to notify other objects 
> about changes in their state.
> 
> The observer pattern provides a way to subscribe and unsubscribe to and from these events
> for any object that implements a subscriber interface.

# Problem

> Imagine that you have two types of object: a **Customer** and a **Store**. The customer is very
> interested in a particular brand of product (say, it's a new model of the iPhone) which should 
> become available in the store very soon.
> 
> The customer could visit the store every day and check product available. But while the 
> product is still en route, most of these trips would be pointless.
> 
> On the other hand, the store could send tons of emails (which might be considered spam) to
> all customers each time a new product becomes available. This would save some customers
> from endless trips to the store. At the same time , it'd upset other customers who aren't
> interested in new products.
> 
> It looks like we've got a conflict. Either the customer wastes time checking product available
> or the store wastes resources notifying the wrong customers.

# Solution 

> The object that has some interesting state is often called *subject*, but since it's also going to
> notify other objects about the changes to its state, we'll call it *publisher*. All other objects that
> want to track changes to the publisher's state are called *subscribers*.
> 
> The Observer patter suggests that you add a subscription mechanism to the publisher class
> so individual objects can subscribe to or unsubscribe from a stream of events coming from
> that publisher. Fear not! Everything isn't as complicated as it sounds. In reality, this mechanism
> consists of 1) an array field for string a list of references to subscriber objects and 2) several
> public methods which allow adding subscribers to and removing them from that list.
> 
> Now, whenever an important event happens to the publisher, it goes over its subscribers and
> calls the specific notification method on their objects.
> 
> Real apps might have dozens of different subscribers classes that are interested in tracking
> events of the same publisher class. You wouldn't want to couple the publisher to all of those
> classes. Besides, you might not event know about some of them beforehand if your publisher
> class is supposed to be used by other people.
> 
> That's why it's crucial that all subscribers implement the same interface and that the publisher
> communicates with them only via that interface should declare the notification 
> method along with a set of parameters that the publisher can use to pass some contextual
> data along with the notification. 
> 
> If your app has several different types of publisher and you want to make your subscribers
> compatible with all of them, you can go even further and make all publishers follow the same
> interface. This interface would only need to describe a few subscription methods. The interface
> would allow subscribers to observe publisher's state without coupling to their concrete classes.

# Pros

> * *Open/Closed Principle*. You can introduce new subscriber classes without having to change  
>   the publisher's code (and vice versa if there's publisher interface).
> 
> * You can establish relations between objects at runtime


# Cons

> * Subscriber are notified in random order.

# Relations with other Patterns

> * **Chain of Responsibility**, **Command**, **Mediator**, and **Observer** address various ways of
>   connecting senders and receivers of requests:
>
>  * *Chain of Responsibility* passes a request sequentially along dynamic chain of potential
>    receivers until one of them handles it.
>
>  * *Command* establishes unidirectional connections between senders and receivers.  
> 
>  * *Mediator* eliminates direct connections between sender and receivers, forcing them to 
>    communicate indirectly via a mediator object.
> 
>  * *Observer* lets receives dynamically subscribe to and unsubscribe from receiving requests.
> 
> * The difference between **Mediator** and **Observer** is often elusive. In most cases, you can
>   implement either of these patterns; but sometimes you can apply both simultaneously. Let'see
>   how can we can do that.
> 
>   The primary goal of *Mediator* is to eliminate mutual dependencies among a set of system 
>   components. Instead, these components become dependent on a single mediator object. The goal
>   of *Observer* is to establish dynamic one-way connections between objects, where some objects
>   act as subordinates of others.
>  
>   There's a popular implementation of the *Mediator* pattern that relies on *Observer*. The mediator 
>   object plays the role of publisher, and the components act as subscribers which subscribe to and
>   unsubscribe from the mediator's events. When *Mediator* is implemented this way, it may look very 
>   similar to *Observer*.
>  
>   When you're confused, remember that you can implement the Mediator pattern in other ways. For   
>   example, you can permanently link all the components to the same mediator object. This 
>   implementation won't resemble *Observer* but will still be an instance of the *mediator* pattern. 
>  
>   Now imagine a program where all components have become publishers, allowing dynamic connections 
>   between each other. There won't be a centralized mediator object, only a distributed set of
>   observers.