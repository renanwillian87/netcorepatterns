
namespace NetCorePatterns.Structural.Facade.Conceptual
{
  // Some facades can work with multiple subsystems at the same time.
  public class Subsystem2
  {
    public string Operation1()
    {
      return "Subsystem2: Ready!\n";
    }

    public string OperationZ()
    {
      return "Subsystem2: Fire!\n";
    }
  }
}
