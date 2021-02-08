using NetCorePatterns.Structural.Proxy.Conceptual;
using System;

namespace NetCorePatterns.Structural.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same code with a proxy:");
            Conceptual.Proxy proxy = new Conceptual.Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}
