
namespace NetCorePatterns.Creational.Builder
{
  using NetCorePatterns.Creational.Builder.Conceptual;
  using System;

  class Program
  {
    static void Main(string[] args)
    {
      // The client code creates a builder object, passes it to the
      // director and then initiates the construction process. The end
      // result is retrieved from the builder objet.
      var director = new Director();
      var builder = new ConcreteBuilder();
      director.Builder = builder;

      Console.WriteLine("Standard basic product: ");
      director.BuildMinimalViableProduct();
      Console.WriteLine(builder.GetProduct().ListParts());

      Console.WriteLine("Standard full featured product: ");
      director.BuildFullFeaturedProduct();
      Console.WriteLine(builder.GetProduct().ListParts());

      // Remember, the Builder pattern can be used without a Director
      // class.
      Console.WriteLine("Custom product: ");
      builder.BuildPartA();
      builder.BuildPartC();
      Console.WriteLine(builder.GetProduct().ListParts());
    }
  }
}
