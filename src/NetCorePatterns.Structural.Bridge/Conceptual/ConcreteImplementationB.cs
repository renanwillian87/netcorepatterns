
namespace NetCorePatterns.Structural.Bridge.Conceptual
{
  class ConcreteImplementationB : IImplementation
  {
    public string OperationImplementation()
    {
      return "ConcreteImplementationA: The result in platform B.\n";
    }
  }
}
