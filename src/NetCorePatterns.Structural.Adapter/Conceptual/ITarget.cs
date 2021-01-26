
namespace NetCorePatterns.Structural.Adapter.Conceptual
{
  // The targert defines the domain-specific interface used by the client code.
  public interface ITarget
  {
    string GetRequest();
  }
}
