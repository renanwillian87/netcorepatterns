
namespace NetCorePatterns.Structural.Facade.Conceptual
{
  // The Subsystem can accept requests either from the facade or client
  // directly. In any case, to the Subsystem, the Facade is yet another
  // client, and it's not apart of the subsystem.
  public class Subsystem1
  {
    public string Operation1()
    {
      return "Subsystem 1: Ready!\n";
    }

    public string OperationN()
    {
      return "Subsytem 1: Go!\n";
    }
  }
}
