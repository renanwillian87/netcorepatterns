
namespace NetCorePatterns.Creational.AbstractMethod.Conceptual
{
  using System;

  // The client code works with factories and products only throuth abstract
  // types: AbstractFactory and AbstractProduct. This lets  you pass any
  // factory or product subclass to the client code without breaking it.
  class Client
  {
    public void Main()
    {
      //
      Console.WriteLine("Client: Testing client code with the first factory type...");
      ClientMehod(new ConcreteFactory1());
      
      Console.WriteLine();

      Console.WriteLine("Client: Testing the same client code with the second factory type...");
      ClientMehod(new ConcreteFactory2());
    }

    public void ClientMehod(IAbstractFactory factory)
    {
      var productA = factory.CreateProductA();
      var productB = factory.CreateProductB();

      Console.WriteLine(productB.UsefulFunctionB());
      Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
  }
}
