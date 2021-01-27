﻿
namespace NetCorePatterns.Structural.Bridge.Conceptual
{
  // The Implementation defines the interface for all implementation classes.
  // It doesn't have to match the abstraction's interface. In fact, the two
  // interfaces can be entirely different. Typically the Implementation
  // interface provides only primitive operations, while the Abstraction
  // defines higher-level operations based on those primitives.
  interface IImplementation
  {
    string OperationImplementation();
  }
}
