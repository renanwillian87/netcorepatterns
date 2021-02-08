
namespace NetCorePatterns.Structural.Proxy.Conceptual
{
  using System;
 
  // The RealSubject contains some core business logic. Usually, RealSubjects
  // are capable of doing some useful work which may also be very slow or
  // sensitive - e.g. correcting input data. A proxy can solve these issues
  // without any changes to the RealSubject's code.
  class RealSubject : ISubject
  {
    public void Request()
    {
      Console.WriteLine("RealSubject: Handling Request.");
    }
  }
}
