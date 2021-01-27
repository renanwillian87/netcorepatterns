
namespace NetCorePatterns.Structural.Bridge.Conceptual
{
  class ConcreteImplementationA : IImplementation
  {
    // Each Concrete Implementations corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    public string OperationImplementation()
    {
      return "ConcreteImplementationA: The result in platform A.\n";
    }
  }
}
