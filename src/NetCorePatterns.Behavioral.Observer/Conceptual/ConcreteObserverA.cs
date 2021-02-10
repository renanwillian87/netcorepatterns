﻿
namespace NetCorePatterns.Behavioral.Observer.Conceptual
{
    using System;

    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
