
namespace NetCorePatterns.Creational.AbstractMethod.Conceptual
{
  // Here's the base interface of another product. All products can
  // interact with each other, but proper interaction is possible only between
  // products of the same concrete variant.
  public interface IAbstractProductB
  {
    // Product B is able to do its own thing...
    string UsefulFunctionB();

    // ...but it also can collaborate with Product A.
    //
    // The Abstract factory makes sure that all products it creates are of
    // the same variant and thus, compatible.
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
  }
}
