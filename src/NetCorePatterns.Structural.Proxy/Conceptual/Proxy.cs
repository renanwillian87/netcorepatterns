
namespace NetCorePatterns.Structural.Proxy.Conceptual
{
    using System;

    // The proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        public void Request()
        {
            if(this.CheckAccesss())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        private bool CheckAccesss()
        {
            // Some real checks should go here
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
