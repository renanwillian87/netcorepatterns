
namespace NetCorePatterns.Creational.Builder.Conceptual
{
  using System.Collections.Generic;

  // It makes sense to use the Builder pattern only when your products are
  // quite complex and require extensive configuration.
  // 
  // Unlike in other creational patterns, different concrete builder can
  // produce unrelated products. In other words, results of various builders
  // may not always follow the same interface.
  public class Product
  {
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
      this._parts.Add(part);
    }

    public string ListParts()
    {
      string str = string.Empty;

      for (int i = 0; i < this._parts.Count; i++)
      {
        str += this._parts[i] + ", ";
      }

      // removind last ",c"
      str = str.Remove(str.Length - 2);

      return "Product parts: " + str + "\n";
    }
  }
}
