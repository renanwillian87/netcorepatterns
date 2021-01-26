
namespace NetCorePatterns.Structural.Adapter.Conceptual
{
  // The Adaptee contains some useful behavior, but its interface is
  // inconpatible with existing client code. The Adaptee needs some
  // adaptiation before the client code can use it.
  class Adaptee
  {
    public string GetSpecificRequest()
    {
      return "Specific request";
    }
  }
}
