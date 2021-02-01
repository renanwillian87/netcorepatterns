﻿
namespace NetCorePatterns.Structural.Facade
{
  using NetCorePatterns.Structural.Facade.Conceptual;

  class Program
  {
    static void Main(string[] args)
    {
      Subsystem1 subsystem1 = new Subsystem1();
      Subsystem2 subsystem2 = new Subsystem2();
      Conceptual.Facade facade = new Conceptual.Facade(subsystem1, subsystem2);
      Client.ClientCode(facade);
    }
  }
}
